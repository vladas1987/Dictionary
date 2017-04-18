using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            myDictionary.Add("key1", "First Item");
            myDictionary.Add("key2", "Second Item");
            myDictionary.Add("key3", "Third Item");
            myDictionary.Add("key4", "Fourth Item");
            myDictionary.Add("key5", "Fifth Item");

            Console.WriteLine("Item represented by the key 'key2' : " + myDictionary["key2"]);

        }
    }
}
