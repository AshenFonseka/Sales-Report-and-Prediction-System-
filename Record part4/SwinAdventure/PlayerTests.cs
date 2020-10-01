using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerIdentifierTest()
        {
            Player TestPlayer = new Player("Adeepa", "Test");

            Assert.IsTrue(TestPlayer.AreYou("me"));
        }



        [TestMethod]
        public void PlayerLocaterTest()
        {
            Player TestPlayer = new Player("Adeepa", "Test");//Player TestPlayer = new Player("Adeepa", "Test");

            Assert.IsTrue(TestPlayer.Locate("me") == TestPlayer);//me
        }

        [TestMethod]
        public void PlayerItemLocaterTest()
        {
            Player TestPlayer = new Player("Adeepa", "Test");// new Player("Adeepa", "Test");

            Item TestItem = new Item(new string[] { "salad", "pasta" }, "pasta salad", "s pasta salad");// { "salad", "pasta" }, "pasta salad", "s pasta salad")

            TestPlayer.Inventory.PutItem(TestItem);
            /*
             Assert.IsTrue(TestPlayer.Locate("salad") == TestItem);
            Assert.IsTrue(TestPlayer.Locate("salad") == TestItem);
             */

            Assert.IsTrue(TestPlayer.Locate("salad") == TestItem);
            Assert.IsTrue(TestPlayer.Locate("salad") == TestItem);
        }

        /*
        
        [TestMethod]
        public void PlayerLacteNothingTest()
        {
            Player TestPlayer = new Player("Adeepa", "Test");

            Assert.IsTrue(TestPlayer.Locate("salad") == null);
        } 
        */

        [TestMethod]
        public void PlayerFullDescriptionTest()
        {
            Player TestPlayer = new Player("Adeepa", "Test");


            Item TestItem = new Item(new string[] { "salad", "pasta" }, "pasta salad", "a pasta salad");
            //salad? / pasta?
            TestPlayer.Inventory.PutItem(TestItem);

            Assert.IsTrue(TestPlayer.FullDescription().Contains("You are Carrying: \n" + "pasta salad" + "\t" + "A pasta salad. " + "\n"));
            // Console.WriteLine(  TestPlayer.FullDescription   ());
            Console.WriteLine(  TestPlayer.FullDescription   ());
        }

        [TestMethod]
        public void PlayerLacteNothingTest()
        {
            Player TestPlayer = new Player("Adeepa", "Test");

            Assert.IsTrue(TestPlayer.Locate("salad") == null);
        }
    }
}
