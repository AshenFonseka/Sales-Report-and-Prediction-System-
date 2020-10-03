using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
using System.Threading.Tasks;

namespace SwinAdventure
{
    public abstract class GameObject : IdentifiableObject
    {
        private string   __name; //_name
        private string   __desc;

      

        public GameObject (string[] ids, string name, string desc) //private  GameObject (string[] ids, string name, string desc)
        {
            __name =  name; //_name

            __desc =  desc; //_desc

            foreach (string id in ids)
            {

            this.AddIdentifier(id);
            }
        }

        public GameObject()
        {

        }

        public string Name
        {
            get => __name;         //   get { return __name; }
            set => __name = value; //   set {__name = value; }
        }

        public string ShortDesc
        {
            get
            {
                return "A" + __name + " " + this.FirstId + ".";
            }
        }

        /*
        public string ShortDesc
        {
            get
            {
                return "A" + __name + " " + this.FirstId + ".";
            }
        }
        */

        public string LongDesc
        {
            get => __desc;          // get {return __desc;}
            set => __desc = value;  // set {__desc = value;}
        }
    }
}
