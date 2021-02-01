using System;

namespace ConsoleMylist
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new  MyDictionary<string>();
            names.Add("Matematik");
            names.Add("Fizik");
            names.Add("Kimya");
            names.Add("Biyoloji");
            Console.WriteLine(names.Lenght);
            Console.WriteLine("**************************");

            MyDictionary<int> times = new MyDictionary<int>();
            times.Add(08);
            times.Add(10);
            times.Add(13);
            times.Add(14);
            Console.WriteLine(times.Lenght);
            Console.WriteLine("**********************");

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********************");

            foreach (var itemm in times.Items)
            {
                Console.WriteLine(itemm);
            }

        }
    }
}
