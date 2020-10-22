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
            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }

        public bool IsElementPresents(string by)
        {
            app.IsElementPresent();
        }

        public bool IsAlertPresents()
        {
            app.IsAlertPresent();
        }
    }
}
