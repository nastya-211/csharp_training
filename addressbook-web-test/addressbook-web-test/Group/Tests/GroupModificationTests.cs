using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("aaa");
            newData.Header = "sss";
            newData.Footer = "ddd";
            app.Groups.ModifyGroup(1, newData);
        }
    }
}
