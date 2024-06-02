using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowTurnUpPortalMay2024.Utilities;

namespace SpecFlowTurnUpPortalMay2024.Pages
{
    internal class LoginPage
    {
        public void loginPage(IWebDriver driver)
        {
            //Exception Handling
            try
            {
                WaitHelper.waitElementisVisible(driver, "Id", "UserName", 10);
                IWebElement UserName = driver.FindElement(By.Id("UserName"));
                IWebElement Password = driver.FindElement(By.Id("Password"));
                IWebElement LogInButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

                //WaitHelper.waitUntilElementisClickable(driver);
                UserName.SendKeys("hari");
                Password.SendKeys("123123");
                LogInButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal Did not Load Successfully");
            }
        }
    }
}
