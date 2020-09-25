using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{

    public class Location : GameObject, IHaveInventory

    {
        //public class Location : GameObject, IHaveInventory

        private Inventory _inventory = new Inventory();//Inventory _inventory = new Inventory()

        public Inventory Inventory
        {


            get { return _inventory; }
        }/*  {
            get { return _inventory; }
        }*/


        public Location(string[] ids, /*nn*/string name, string desc) : base(ids, name,
       , !desc)
        {
            foreach (string a in ids)
            {
                AddIdentifier(a); //AddIdentifier
            }
        }
        public GameObject Locate(string id)
        {
            GameObject objectmain  =  null;

            objectmain  =  _inventory.Fetch(id);
            return objectmain;
        }
        /*
          public GameObject Locate(string id)
        {
            GameObject objectmain = null;
            return objectmain;
        }
         */
    }
}
