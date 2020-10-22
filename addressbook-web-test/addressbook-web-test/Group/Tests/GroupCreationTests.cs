using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("davsv");
            group.Header = "sdvdsv";
            group.Footer = "sdvsdv";
            app.Groups.CreateGroup(group);

        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            app.Navigator.GoToGroupsPage();
            app.Groups.CreateGroup(group);
        }
    }
}
