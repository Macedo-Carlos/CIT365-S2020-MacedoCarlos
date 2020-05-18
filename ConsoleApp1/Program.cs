using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList theBooks = new ArrayList();
            theBooks.Add("Nephi");
            theBooks.Add("Jacob");
            theBooks.Add("Alma");
            theBooks.Add("Moroni");
            Console.WriteLine("Count: {0}", theBooks.Count);
        }
    }
}
