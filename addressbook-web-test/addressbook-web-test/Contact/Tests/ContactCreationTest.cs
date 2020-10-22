using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {


        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("davsv");
            contact.Lastname = "sdvdsv";
            contact.Nickname = "sdvsdv";
            app.Contacts.CreateContact(contact);

        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("");
            contact.Lastname = "";
            contact.Nickname = "";
            app.Navigator.GoToGroupsPage();
            app.Contacts.CreateContact(contact);
        }
    }
}