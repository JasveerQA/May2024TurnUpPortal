using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal_may2024_Tests.Utilities
{
    internal class WaitHelper
    {
        public static void waitElementToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            if (locatorType.Equals("XPath"))
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorType)));
            }
            if (locatorType.Equals("Id"))
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorType)));
            }
            if (locatorType.Equals("Name"))
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(locatorType)));

                //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
        }


        public static void waitElementisVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            if(locatorType.Equals("XPath"))
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorType)));
            }
            if(locatorType.Equals("Id"))
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorType)));
            }
            if(locatorType.Equals("Name"))
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locatorType)));
                    
            }
        }
        //Explicit wait


        //Implicit Wait:  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }
}
