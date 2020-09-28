﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Bag : Item, IHaveInventory
    {
        public Bag(string[] ids, string name, string desc)
        {
            _inventory = new Inventory();
            this.Name = name;
            this.LongDesc = desc;

            foreach(string id in ids)
            {
                this.AddIdentifier(id);
            }
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id) == true)
            {
                return this;
            }
            else if(_inventory.HasItem(id) == true)
            {
                return _inventory.FetchItem(id);
            }

            return null;
        }

        public string FullDescription()
        {
            string InventoryDescription = "In " + this.Name + "You are Carrying:\n";
            foreach (string Item in _inventory.ItemList())
            {
                InventoryDescription = InventoryDescription + Item;
            }
            return InventoryDescription;
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
            set
            {
                _inventory = value;
            }
        }
    }
}
