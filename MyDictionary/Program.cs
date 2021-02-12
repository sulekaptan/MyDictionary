using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> dictionary = new MyDictionary<string>();
            dictionary.Add("Legend");
            dictionary.Add("Unstoppable");
            dictionary.Add("Stronger");
            dictionary.Add("Stay");
            dictionary.Add("Revolution");
            dictionary.Add("Run like a rebel");

            dictionary.List();
        }
    }
}
