using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps
    {
        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage;

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        [Given(@"I navigate to the application")]
        public void GivenINavigateToTheApplication()
        {
            _driverHelper.Driver.Manage().Window.Maximize();
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click to login link")]
        public void GivenIClickToLoginLink()
        {
            homePage.clickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword(data.UserName, data.Password);
        }

        [Given(@"I click Login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged into the application")]
        public void ThenIShouldSeeUserLoggedIntoTheApplication()
        {
            Assert.That(homePage.lnkLogOffExisted, Is.True, "Log out button did not displayed");
        }

    }
}
