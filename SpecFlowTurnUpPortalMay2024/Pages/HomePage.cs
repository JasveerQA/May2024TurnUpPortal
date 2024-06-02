using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTurnUpPortalMay2024.Pages
{
    internal class HomePage
    {
        public void homePage(IWebDriver driver)
        {
            IWebElement AdministrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationMenu.Click();
            IWebElement TimeandMateiralsMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeandMateiralsMenu.Click();

        }
    }
}
