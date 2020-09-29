using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure.Tests
{
    [TestClass()]
    public class ItemTests
    {
        /*
         
           [TestMethod()]
        public void LongDescriptionTest()
        {
            Item id = new Item(new string[] { "potato", "baked" }, "baked potato", "a baked potato");
            Assert.IsTrue(id.ShortDesc == ("A baked potato "));
        }    
             
             
         */
        [TestMethod]
        public void ItemIsIdentifiableTest()
        {
            Item id = new Item(new string[] { "potato", "baked" }, "baked patato", "a baked potato");

            Assert.IsTrue(id.AreYou("potato"));
            //potato?

            Assert.IsTrue(id.AreYou("baked"));
                //baked?
        }



        [TestMethod()]
        public void LongDescriptionTest()
        {
            Item id = new Item(new string[] { "potato", "baked" }, "baked potato", "a baked potato");
            // { "potato", "baked" }, "baked potato", "a baked potato");


            Assert.IsTrue(id.ShortDesc == ("A baked potato "));
        }


        [TestMethod()]


        public void ShortDescriptionTest()
        {

            /*
              Item id = new Item(new string[] { "potato", "baked" }, "baked potato", "a baked potato");
            Assert.IsTrue(id.ShortDesc == ("A baked potato patato"));*/

            Item id = new Item(new string[] { "potato", "baked" }, "baked potato", "a baked potato");
            Assert.IsTrue(id.ShortDesc == ("A baked potato patato"));//baked?
        }

      

    }
}
