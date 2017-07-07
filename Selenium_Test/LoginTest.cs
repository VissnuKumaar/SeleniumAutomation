using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Test
{
    /// <summary>
    /// Summary description for LoginTest
    /// </summary>
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void LoginForSuccessfulCredentials()
        {
            var driver = new InternetExplorerDriver();
            try
            {
                string url = "http://localhost:12180/Login.aspx";
                driver = new InternetExplorerDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("txtUsername")).SendKeys("admin");
                driver.FindElement(By.Id("txtPassword")).SendKeys("admin");
                driver.FindElement(By.Id("btnlogin")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                var message = driver.FindElementById("message");
                Assert.AreEqual("Login Failed", message.Text);
                driver.Close();
                driver.Quit();
            }
            catch
            {
                ITakesScreenshot screenshotdriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotdriver.GetScreenshot();
                screenshot.SaveAsFile("C:/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
    }
}
