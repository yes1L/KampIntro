using System;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(518, "Mustafa");
            dictionary.Add(387, "Kazım");
            dictionary.Add(156, "Sanime");
            dictionary.Add(894, "Göksel");

            dictionary.Listele();

        }
    }
}
