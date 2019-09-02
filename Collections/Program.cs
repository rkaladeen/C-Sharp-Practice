using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Practice");
            // arrays();
            // flavors();
            // dict();
        }
        static void arrays() //Three Basic Arrays
        {
        string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
        int[] nums = new int[] {0,1,2,3,4,5,6,7,8,9};
        bool[] state = new bool[] {true, false, true, false, true, false, true, false, true, false,};
          Console.WriteLine("[{0}]", string.Join(", ", nums));
          Console.WriteLine("[{0}]", string.Join(", ", names));
          Console.WriteLine("[{0}]", string.Join(", ", state));
        }

        static void flavors()
        {
          List<string> flavors = new List<string>();
          flavors.Add("vanilla1");
          flavors.Add("vanilla2");
          flavors.Add("vanilla3");
          flavors.Add("vanilla4");
          flavors.Add("vanilla5");

          Console.WriteLine(flavors.Count);
          Console.WriteLine(flavors[2]);
          flavors.Remove("vanilla3");

          Console.WriteLine("[{0}]", string.Join(", ", flavors));
        }

        static void dict()
        {
          Random rand = new Random();
          string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};

          List<string> flavors = new List<string>();
          flavors.Add("Vanilla");
          flavors.Add("Chocolate");
          flavors.Add("Strawberry");
          flavors.Add("Coffee");
          flavors.Add("Mint");
          
          Dictionary<string, string> profile = new Dictionary <string, string>();

          foreach(string name in names)
          {
            int ran = rand.Next(0, flavors.Count - 1);
            profile.Add(name, flavors[ran]);
          }

          foreach (KeyValuePair<string,string> entry in profile)
          {
            Console.WriteLine(entry.Key + " - " + entry.Value);
          }
        }
    }
}
