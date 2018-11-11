using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppcollections1
{
    class Dictionary1

    {
        //public static void Update()
        //{

        //}

        static void Main(string[] args)

        {
            Dictionary<string, Dictionary<string, string>> info =
   new Dictionary<string, Dictionary<string, string>>
   {
        {
            "Gen",
            new Dictionary<string, string>
            {
                {"name", "Genesis"},
                {"chapters", "50"},
                {"before", ""},
                {"after", "Exod"}
            }
        },
        {
            "Exod",
            new Dictionary<string, string>
            {
                {"name", "Exodus"},
                {"chapters", "40"},
                {"before", "Gen"},
                {"after", "Lev"}
            }
        }
         };


        }

    }
}
