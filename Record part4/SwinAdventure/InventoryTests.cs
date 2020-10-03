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
    public class InventoryTests


    {
        [TestMethod]
        public void TestNoItemFind()
        {
            Item TestItem = new Item(new string[]  
            
            { "pasta", "salad" }, "pasta salad", "a pasta salad");

            Inventory TestInventory = new Inventory();//Inventory TestInventory = new Inventory();
            /*
             TestInventory.PutItem(TestItem);
             */
            TestInventory.PutItem(TestItem);

            Assert.IsFalse(TestInventory.HasItem("chicken"));//chicken

        }


        [TestMethod]

        public void TestTakeItem()
        {


            Item TestItem = new Item(new string[] { "salad", "pasta" }, "pasta salad", "a psta salad");//erdtyui
            //{ "salad", "pasta" }, "pasta salad", "a psta salad");

            Inventory TestInventory = new Inventory();

            TestInventory.PutItem(TestItem);//testitem
            Assert.IsTrue(TestInventory.HasItem("pasta"));
            //paasta
            TestInventory.TakeItem(TestItem);
            /*
             
             TestInventory.PutItem(TestItem);
            Assert.IsTrue(TestInventory.HasItem("pasta"));
            TestInventory.TakeItem(TestItem);
             */

            Assert.IsFalse(TestInventory.HasItem("pasta"));
        }




        [TestMethod]
        public void TestFetchItems()
        {
            Item TestItem = new Item(new string[] { "salad", "pasta" }, "pasta salad", "a pasta salad");
            Inventory TestInventory = new Inventory();
            /*
            Item TestItem = new Item(new string[] { "salad", "pasta" }, "pasta salad", "a pasta salad");  
             */
            TestInventory.PutItem(TestItem);
            //Assert.IsTrue(TestInventory.FetchItem("pasta") == TestItem);
            Assert.IsTrue(TestInventory.FetchItem("pasta") == TestItem);
                //pasta??
            Assert.IsTrue(TestInventory.HasItem("pasta"));
        }

       

        [TestMethod]
        public void TestItemList()
        {
            Item TestItem = new Item(new string[] { "salad", "pasta" }, "pasta salad", "a pasta salad");

            // { "salad", "pasta" }, "pasta salad", "a pasta salad");




            Item TestItem2 = new Item(new string[] { "chicken", "baked" }, "baked chicken", "a baked chicken");

            Inventory TestInventory = new Inventory();

            TestInventory.PutItem(TestItem);
            TestInventory.PutItem(TestItem2);
            /*
             TestInventory.PutItem(TestItem);
            TestInventory.PutItem(TestItem2);
             */
            Assert.IsTrue(TestInventory.HasItem("salad"));

            Assert.IsTrue(TestInventory.HasItem("chicken"));//Assert.IsTrue(TestInventory.HasItem("chicken"));


            Assert.IsTrue(TestInventory.ItemList().Contains("pasta salad" + "\t" + "A pasta salad salad" + "\n"));
            // Assert.IsTrue(TestInventory.ItemList().Contains("baked chicken" + "\t" + " A baked chicken chicken." + "\n"));
            Assert.IsTrue(TestInventory.ItemList().Contains("baked chicken" + "\t" + " A baked chicken chicken." + "\n"));
        }
    }
}
