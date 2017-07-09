using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();
            //Add four of your favorite car model names to the set.
            Showroom.Add("350Z");
            Showroom.Add("Model S");
            Showroom.Add("TTRS");
            Showroom.Add("540C");

            Console.WriteLine("***********");
            foreach(string n in Showroom)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine("***********");
            //Print to the console how many cars are in your show room.
            Console.WriteLine("There are {0} cars on the Showroom", Showroom.Count);
            Console.WriteLine("***********");
            //Pick one of the items in your show room and add it to the set again.
            Showroom.Add("TTRS");
            //Print your showroom again, and notice how there's still only one representation of that model in there.
            Console.WriteLine("***********");
            foreach(string n in Showroom)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine("***********");
            Console.WriteLine("There are {0} cars on the Showroom", Showroom.Count);
            Console.WriteLine("***********");
            //Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Impala");
            UsedLot.Add("Passat");
            //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            //Print to Show
            Console.WriteLine("***********");
            foreach(string n in Showroom)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine("***********");
            Console.WriteLine("There are {0} cars on the Showroom", Showroom.Count);
            Console.WriteLine("***********");
            //You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("350Z");
            //Print to Show
            Console.WriteLine("***********");
            foreach(string n in Showroom)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine("***********");
            Console.WriteLine("There are {0} cars on the Showroom", Showroom.Count);
            Console.WriteLine("***********");
            //Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard
            // full of old cars has approached you about buying the entire inventory. In the new set, 
            //add some different cars, but also add a few that are the same as in the Showroom set.
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Grand Prix");
            Junkyard.Add("Camero");
            Junkyard.Add("350Z");
            Junkyard.Add("Impala");
            Junkyard.Add("Model S");
            //Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            HashSet<string> Common = new HashSet<string>(Showroom);

            Common.IntersectWith(Junkyard);
            
            //Write it Out
            Console.WriteLine("***********");
            foreach(string n in Common)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine("***********");
            Console.WriteLine("There are {0} cars on the Common", Common.Count);
            Console.WriteLine("***********");
            //Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            
            Showroom.UnionWith(Junkyard);
            //Write it out
            Console.WriteLine("***********");
            foreach(string n in Showroom)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine("***********");
            Console.WriteLine("There are {0} cars on the Showroom", Showroom.Count);
            Console.WriteLine("***********");
            
            
        }
    }
}
