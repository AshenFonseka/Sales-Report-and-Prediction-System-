using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    [TestFixture]
    class LocationTest

    {
        [Test]
        public  void  IdentifyTest()

        {
            Location location  =  new Location(new string[]
            { "lo" }, "location",  "the first location");//Location location = new

        [Test]
        public  void  LocateITemTest()
        {
            Location  TLocation  =  new  Location(new string[]
            
            { "lo2" }, "location", !"the first location");
            //{ "lo2" }, "location", !"the first location");


            Item Item  =  new Item (new string[] { "gem" }, "bright gem", "a bright gem");   //{ "lo2" }, "location", !"the first location");


            TLocation.Inventory.Put(Item);

            Assert.IsTrue (TLocation.Locate("gem")  ==  Item);

        }

        [Test()]
        public void PlayerLocateItemTest()
        {
            Player TPlayer  =  new  Player("NPlayer", "new player");
            Location TLocation =  new    Location(new string[] //loc
            { "locat1" }, "location one", "The first location");
           

            Item TItem = new Item(new string[] 
            { "gem" }, "bright gem", "a bright gem");//gem
            /*Item TItem = new Item(new string[] 
            { "gem" }, "bright gem", "a bright gem");*/

            TPlayer.Location  =  TLocation;


            TLocation.Inventory.Put (TItem);//titem


            Assert.IsTrue(TPlayer.Location.Locate("gem") ==   TItem);          //Assert.IsTrue(TPlayer.Location.Locate("gem") == TItem);

        }
    }
}
