using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main()
        {
            //Function to Display for DRY sake
            void DisplaySet(HashSet<string> set)
            {
                Console.WriteLine("*********");
                foreach (string i in set)
                {
                    Console.WriteLine(" {0}", i);
                }
                Console.WriteLine("There are {0} cars on the Showroom", set.Count);
                Console.WriteLine("*********");
            }


            //Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();
            //Add four of your favorite car model names to the set.
            Showroom.Add("350Z");
            Showroom.Add("Model S");
            Showroom.Add("TTRS");
            Showroom.Add("540C");

            DisplaySet(Showroom);
            //Pick one of the items in your show room and add it to the set again.
            Showroom.Add("TTRS");
            //Print your showroom again, and notice how there's still only one representation of that model in there.
            DisplaySet(Showroom);
            //Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Impala");
            UsedLot.Add("Passat");
            //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            //Print to Show
            DisplaySet(Showroom);
            //You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("350Z");
            //Print to Show
            DisplaySet(Showroom);
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
            DisplaySet(Junkyard);
            //Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            
            Showroom.UnionWith(Junkyard);
            //Write it out
            DisplaySet(Showroom);
            
            
        }
    }
}
