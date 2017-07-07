using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            int Results = 0;

            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                Results = Validate_Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (Results == 1)
                {
                    Response.Redirect("http://localhost:12180/Welcome.aspx");
                }
                else
                {
                    Response.Redirect("http://localhost:12180/Error.aspx");
                    //lblMessage.Text = "Invalid Login";
                    //lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "Please make sure that the username and the password is Correct";
            }
        }
        public int Validate_Login(String Username, String Password)
        {
            SqlConnection con = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=seleniumtest");
            SqlCommand cmdselect = new SqlCommand();
            cmdselect.CommandType = CommandType.StoredProcedure;
            cmdselect.CommandText = "[dbo].[prcLoginv]";
            cmdselect.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = Username;
            cmdselect.Parameters.Add("@UPassword", SqlDbType.VarChar, 50).Value = Password;
            cmdselect.Parameters.Add("@OutRes", SqlDbType.Int, 4);
            cmdselect.Parameters["@OutRes"].Direction = ParameterDirection.Output;
            cmdselect.Connection = con;
            int Results = 0;
            try
            {
                con.Open();
                cmdselect.ExecuteNonQuery();
                Results = (int)cmdselect.Parameters["@OutRes"].Value;
            }
            catch (SqlException ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                cmdselect.Dispose();
                if (con != null)
                {
                    con.Close();
                }
            }
            return Results;
        }
    }
}