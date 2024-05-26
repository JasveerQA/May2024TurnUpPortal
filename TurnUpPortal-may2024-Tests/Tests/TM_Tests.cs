using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal_may2024_Tests.Tests
{
    internal class TM_Tests
    {

        IWebDriver driver = new ChromeDriver();
        //WebDriverWait wait;



        //[setUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //loginPage();
            //homePage();

        }
        public void LoginPage()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")).Click();
        }
        public void HomePage()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
        public void TearDown()
        {
            driver.Quit();
        }
        [Test, Order (1)]
          public void CreateTMRecordtest()
        {
            SetUp();
            LoginPage();
            HomePage();
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]")).Click();
            driver.FindElement(By.Id("Code")).SendKeys("hello");
            driver.FindElement(By.Id("Description")).SendKeys("Yess");
            driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("1000");
            driver.FindElement(By.Id("SaveButton")).Click();
            
            TearDown();
        }
        [Test, Order(2)]
        public void EditTMRecordtest()
        {
            SetUp();
            LoginPage();
            HomePage();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[5]/a[1]")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]")).Click();
            driver.FindElement(By.Id("Code")).SendKeys("Hi");
            driver.FindElement(By.Id("Description")).SendKeys("No");
            driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")).Click();
            //driver.FindElement(By.Id("Price")).SendKeys("2000");
            driver.FindElement(By.Id("SaveButton"))
                  .Click();
            
            TearDown();
        }
        [Test, Order(3)]
        public void DeleteTMRecordtest()
        {
            SetUp();
            LoginPage();
            HomePage();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[7]/td[5]/a[2]")).Click();
            driver.SwitchTo().Alert().Accept();


        }
    }
}


