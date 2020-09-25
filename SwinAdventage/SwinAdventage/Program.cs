using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    class Program
    {
        static  void  Main(string[] args)
        {
            string  text,  descrip,  n;//test
            string[]  option  =  new string[5];

            var  slist  =  new  List<string> ();

            Console.WriteLine ( "Enter players text");
            text  =  Console.ReadLine ();
            Console.WriteLine ("Enter players description");
            descrip  =  Console.ReadLine();
            /*
             Console.WriteLine ( "Enter players text");
            text  =  Console.ReadLine ();
            Console.WriteLine ("Enter players description");
            descrip  =  Console.ReadLine();*/

            Player player  =  new Player (text, descrip);

            Item item1 =  new  Item (new  String[] 
             { "item1" }, "an item", "The first item"); //item1

            Item item2 =  new  Item (new String[] 
            { "item2" }, "an item", "The second item");//item2

            Bag  bag  =  new  Bag (new String[] { "bag" }, "My bag", "first bag"); //bag

            Item item3  =  new  Item (new String[] 
            { "item3" }, "an item", "The third item"); //item3

            LookCommand  look  =  new LookCommand(new string[] { "look" }); // LookCommand  look  =  new LookCommand(new string[] { "look" });


            player.Inventory.Put (item1);//item1

            player.Inventory.Put (item2); //item2

            /*player.Inventory.Put (item1);
            player.Inventory.Put (item2);*/

            player.Inventory.Put (bag);
            bag.Inventory.Put (item3);


            for (int x = 0; x < 10; x++)//(int x = 0; x < 10; x++)
            {
                Console.WriteLine ("Enter command, put spaces between the words");//Console.WriteLine ("Enter command, put spaces between the words");
                n = Console.ReadLine ();// n = Console.ReadLine ();


                slist  =  n.Split(' ').ToList();

                option  =  slist.ToArray();
                /* option  =  slist.ToArray();*/

                Console.WriteLine (look.Execute(player, option));

            }
        }
    }
}
