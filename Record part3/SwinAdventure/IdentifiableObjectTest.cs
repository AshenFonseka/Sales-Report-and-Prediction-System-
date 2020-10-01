using System;
using System.Collections.Generic;
using System.Linq;
using SwinAdventure;


using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwinAdventure.Tests
{
    [TestClass()]
    public class IdentifiableObjectTests
    {

        [TestMethod()]
        public void IdentifiableObjectTest()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });

            Assert.IsTrue(id.AreYou("Fred"));
            Assert.IsTrue(id.AreYou("bob"));
            Assert.IsFalse(id.AreYou("wilma"));
            Assert.IsFalse(id.AreYou("boBy"));
            Assert.IsFalse(id.AreYou("FReD"));
            Assert.IsFalse(id.AreYou("B0b"));
        }

        [TestMethod()]
        public void FirstIDTest()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });

            Assert.IsTrue(id.FirstId == "fred");
        }

        [TestMethod()]
        public void AddIDTest()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });

            id.AddIdentifier("wilma");

            Assert.IsTrue(id.AreYou("fred"));
            Assert.IsTrue(id.AreYou("bob"));
            Assert.IsTrue(id.AreYou("wilma"));

        }

    }
}
