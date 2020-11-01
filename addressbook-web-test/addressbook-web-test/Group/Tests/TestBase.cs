using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTest
{
    public class TestBase
    {
        protected ApplicationManager app;

        

        [SetUp]
        public void SetupTest()
        {

            app = TestSuiteFixture.app;
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
