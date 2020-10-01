using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SwinAdventure
{
    public class Inventory : GameObject
    {
        private List<Item> _inventory;

        public Inventory()
        {
                _inventory = new List<Item>();
        }
        //IKnv entory=new list

        public void PutItem(Item NewItem)
        {
            _inventory.Add(NewItem);//Add(NewItem)



        }

        public bool HasItem(string id)
        {
            foreach (Item Check in _inventory)
            {

                //if (Check.AreYou(id) == true)
                if (Check.AreYou(id) == true)

                {
                    return true;//false

                }
            }
            return false;//true
        }

        /*

            public Inventory()
         {
                 _inventory = new List<Item>();
         }  
              */

        public Item TakeItem(Item NewItem)
        {
            //RemokveApproval
            bool RemoveApproval = false;

            foreach (Item Check in _inventory)
            {
                if(NewItem == Check)
                // if(NewItem == Check)
                {
                    //RemoveApproval = true;
                    RemoveApproval = true;

                }

            }

            if (RemoveApproval == true)
            {
                _inventory.Remove(NewItem);
                return NewItem;
            }
            /*else
            {
                return null;
            }*/

            else
            {
                return null;
            }
        }

        public List<string> ItemList()
        {
            List<string> ItemList = new List<string>();

            foreach (Item Check in _inventory)//_pinhgfdxcfgvh
            {
                //
                ItemList.Add   ( Check.Name  + "\t" +   Check.ShortDesc + "\n");
            }//Check.ShortDesc 

            return ItemList;
        }//item 



        public Item FetchItem(string id)
        {

            foreach(Item InventoryItem in _inventory)

            {

                /* if (InventoryItem.AreYou(id) == true)
                {

                    return InventoryItem;
                }*/
                if (InventoryItem.AreYou(id) == true)
                {

                    return InventoryItem;//inventory
                }
            }
            return null;//null
        }

        
    }
}
