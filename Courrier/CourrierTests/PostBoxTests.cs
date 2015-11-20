using Microsoft.VisualStudio.TestTools.UnitTesting;
using pqtcity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcity.Tests
{
    [TestClass()]
    public class PostBoxTests
    {
        PostBox objPostBox;

        [TestMethod()]
        public void distributeCourrierTest()
        {
            objPostBox = new PostBox();

            Assert.IsNotNull(objPostBox);
            Assert.AreEqual(0, objPostBox.listCourrierReceive.Count);
            objPostBox.distributeCourrier();
        }
    }
}