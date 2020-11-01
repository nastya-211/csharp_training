using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newContactData = new ContactData("asd");
            newContactData.Lastname= "qwe";
            newContactData.Nickname = "zxc";
            app.Contacts.ModifyContact(1, newContactData);
        }
    }
}
