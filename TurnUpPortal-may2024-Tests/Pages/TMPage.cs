using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal_may2024_Tests.Utilities;

namespace TurnUpPortal_may2024_Tests.Pages
{
    internal class TMPage
    {
        public void createTMRecord(IWebDriver driver)
        {
            //Actions
            IWebElement CreateTMRecord = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            //driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]")).Click();

            IWebElement Code = driver.FindElement(By.Id("Code"));
            IWebElement Description = driver.FindElement(By.Id("Description"));
            IWebElement Price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement PriceTextBox = driver.FindElement(By.Id("Price"));
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            CreateTMRecord.Click();
            TypeCode.Click();
            Code.SendKeys("Jess");
            Description.SendKeys("MyName");
            Price.Click();
            PriceTextBox.SendKeys("1000");
            SaveButton.Click();

            //Assertions
            Thread.Sleep(9000);
            //Explicit Wait --> Go to last page
            WaitHelper.waitElementToBeClickable(driver, "XPath",  "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 10);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")));
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            // Get Time and mateiarl record Page count
            WaitHelper.waitElementisVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/ul/li[2]/span", 5);
            int tmRecordPageCount = Int32.Parse(driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/ul/li[2]/span")).Text);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/ul/li[2]/span")));
            //int tmPageRecordCount = Int32.Parse(driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/ul/li[2]/span")).Text);

            //Go back to the first page
            WaitHelper.waitElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[1]/span", 10);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[1]/span")).Click();
            //"//span[@class='k-icon k-i-seek-w']"
            Thread.Sleep(3000);

            //for (int i=1; i<=tmPageRecordCount;i++)
            //{
            // Get T$M Records per page count

            //int tmRecordsPerPageCount = Int32.Parse(driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/span[1]/span/span/span[1]")).Text);

            //for (int j=0; j<=tmRecordsPerPageCount;j++)
            //{
            //String code = driver.FindElement(By.XPath("//tr["+j+"]/td[1]")).Text;
            //String typeCode = driver.FindElement(By.XPath("//tr["+j+"]/td[2]")).Text;
            //String description = driver.FindElement(By.XPath("//tr[" + j + "]/td[3]")).Text;
            //String Price = driver.FindElement(By.XPath("//tr[" + j + "]/td[4]")).Text;

            //if (code == "Jess")
            //{
            //Assert.That(code == "Jess", "Code Value doesnt match");
            // Assert.That(typeCode == "M", "typecode value doesnt match");
            //Assert.That(description == "MyName", "Description Value doesnt match");
            //Assert.That(Price.Contains("1000"), "Price value doesnt match");
            //i = tmPageRecordCount;
            // break;

            // }
            //}
            //Click on the next page
            //driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]/span")).Click();

            String codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[1]")).Text;
            String typecodeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[2]")).Text;
            String descriptionText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[3]")).Text;
            String priceText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[4]")).Text;

            Assert.That(codeText == "Jess", "Code value doesnt match");
            Assert.That(typecodeText == "M", " Type Code value doesnt match");
            Assert.That(descriptionText == "MyName", "Description Value Doesn match");
            Assert.That(priceText.Contains("1000"), "Price value doesnt match");


        }
        public void editTMRecord(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[8]/td[5]/a[1]")).Click();

            //driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]")).Click();
            driver.FindElement(By.Id("Code")).SendKeys("Aarav");

            //driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("YourName");
            driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("2000");
            driver.FindElement(By.Id("SaveButton")).Click();

            //Assertions
            String codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[1]")).Text;
            String typecodeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[2]")).Text;
            String descriptionText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[3]")).Text;
            String PriceText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[4]")).Text;
            Assert.That(codeText == "Aarav", "Code value doesnt match");
            Assert.That(typecodeText == "M", "typecode value doesnt match");
            Assert.That(descriptionText == "YourName", "Description Value doesnt match");
            Assert.That(PriceText.Contains("2000"), "Price doesnt match");

        }
        public void deleteTMRecord(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[2]")).Click();
            driver.SwitchTo().Alert().Accept();
            //TearDown();

            //Assertions
            String codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[1]")).Text;
            String typecodeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[2]")).Text;
            String descriptionText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[3]")).Text;
            String PriceText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[4]")).Text;
            Assert.That(codeText != "Aarav", "Code value doesnt match");
            Assert.That(typecodeText != "M", "typecode value doesnt match");
            Assert.That(descriptionText != "YourName", "Description Value doesnt match");
            Assert.That(!PriceText.Contains("2000"), "Price doesnt match");

        }
    }
}
