using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTurnUpPortalMay2024.Pages;
using SpecFlowTurnUpPortalMay2024.Utilities;

namespace SpecFlowTurnUpPortalMay2024.StepDefinitions
{
    [Binding]
    public class TMTestsStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();
        [Before]

        public void setUp()
        {
            driver = new ChromeDriver();
        }

        [After]
        public void CleanUp()
        {
            driver.Quit();
        }
        [Given(@"user logs into turnup portal")]
        public void GivenUserLogsIntoTurnupPortal()
        {
            
            loginPageObj.loginPage(driver);   
        }

        [Given(@"user navigates to the home page")]
        public void GivenUserNavigatesToTheHomePage()
        {
            homePageObj.homePage(driver);
        
            }

        [When(@"user creates a TM record")]
            public void WhenUserCreatesATMRecord()
        {
                tmPageObj.createTMRecord(driver);

                }

        [Then(@"new TM record should be created successfully")]
        public void ThenNewTMRecordShouldBeCreatedSuccessfully()
        {
            tmPageObj.verifyTMRecordCreated(driver, "Jess");
        }

        

    }
}
