using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppcollections1
{
    class Dictionary

    {

        static void Main(string[] args)

        {
           Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "sateesh");
            names.Add(2, "sathya");
            names.Add(3, "sreedhar");
            names.Add(4, "subbu");
            names.Add(5, "chandra");
            
            Console.WriteLine("total elements");

            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);

            }
           
            Console.WriteLine("after updating elemetns");
            names.Remove(4);

            names.Add(4, "bitta");
            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);

            }
            Console.WriteLine("after removing elemetns");
            names.Remove(4);
            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);

            }
            Console.ReadLine();

        }
    }
}

