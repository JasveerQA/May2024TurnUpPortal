using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal_may2024_Tests.Pages;
using TurnUpPortal_may2024_Tests.Utilities;

namespace TurnUpPortal_may2024_Tests.Tests
{
    internal class TM_Tests : CommonDriver
    {

        //IWebDriver driver = new ChromeDriver();

        WebDriverWait wait;
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [SetUp]
        public void SetUp()
        {
            //IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            loginPageObj.loginPage(driver);
            homePageObj.homePage(driver);
            
        }
        
        
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        [Test, Order (1)]
          public void createTMRecordtest()
        {
            tmPageObj.createTMRecord(driver);
        }
        [Test, Order(2)]
        public void editTMRecordtest()
        {
            tmPageObj.editTMRecord(driver);   

        }
        [Test, Order(3)]
        public void deleteTMRecordtest()
        {
            tmPageObj.deleteTMRecord(driver);                  

        }
    }
}


