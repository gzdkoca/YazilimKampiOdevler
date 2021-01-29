using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> MyDictionary = new MyDictionary<string, int>();
            MyDictionary.Add("Book1", 300);
            MyDictionary.Add("Book2", 577);

            Console.WriteLine("Book: " + MyDictionary.Keys[0] + "  Number of Pages: " + MyDictionary.Values[0]);
            Console.WriteLine("Book: " + MyDictionary.Keys[1] + "  Number of Pages: " + MyDictionary.Values[1]);

        }
    }
}
