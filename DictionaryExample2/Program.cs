using System;

namespace DictionaryExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(42, "Konya Plakası");
            myDictionary.Add(07, "Antalya Plakası");
            myDictionary.Add(35, "İzmir Plakası");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
