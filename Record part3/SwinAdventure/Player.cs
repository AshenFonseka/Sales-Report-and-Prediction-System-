using System;
using System.Collections.Generic;
using System.Text;

namespace SwinAdventure
{
    public class Player : GameObject,IHaveInventory
    {
        private Inventory _inventory;

        public  Player()
        {
            //
        }

        public Player(string name, string desc):base(new string[] { "me", "inventory"} , name, desc)
        {
            this.Name = name;//this.Name = __name;

            this.LongDesc = desc;//this.LongDesc = desc;

            _inventory  =   new   Inventory();

        }

        public GameObject Locate(string id)
        {
            if  ( this.AreYou (id ) )
            { return this; }//return

            /*
             else if (this.Inventory.HasItem(id))
            { return this._inventory.FetchItem(id); }
            return null;
             */
            else if (this.Inventory.HasItem(id))
            { return this._inventory.FetchItem(id); }
            return null;
        }

        public Inventory Inventory
        {
            get => _inventory;
            //get{return _inventory;}
            set => _inventory = value;
            //set{_inventory = value;}
        }

        public string FullDescription()
        {
            string InventoryDescription = "You are Carrying: \n"; //string InventoryDescription = ;

            foreach (string Item in _inventory.ItemList())
            /*
            foreach (string Item in _inventory.ItemList())
           {InventoryDescription = InventoryDescription + Item;}    
            */
            { InventoryDescription = InventoryDescription + Item;}
            return InventoryDescription;
        }

        
    }

}
