using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTest
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {


        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.SelectContact(2);
            app.Contacts.RemoveContact();
        }
    }
}