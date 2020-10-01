using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace SwinAdventure
{
    public class Item : GameObject//item
    {
        public Item ()
        {

        }

        //public Item (){}
        



    public Item(string[] idents, string name, string desc)//public Item(string[] idents, string name, string desc)
        {
            Name = name; LongDesc = desc;

            foreach (string id in idents)
            {

                //this.Addb

                this.AddIdentifier(id);
            }


        }
    }
}
