using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Concurreantdictionary
    {
        
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
            dictionary.TryAdd("1", "First");
            dictionary.TryAdd("2", "Second");
            dictionary.TryAdd("3", "Third");
            dictionary.TryAdd("4", "Fourth");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            Console.WriteLine("after adding");

            dictionary.TryAdd("19", "bitta");
            string data = "";
            dictionary.TryRemove("1",out data);

            dictionary["2"] =  "four";
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            
        }
    }
}
