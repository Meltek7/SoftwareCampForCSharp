using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> devices = new MyDictionary<int, string>();


            devices.Add(1, "Lara");
            devices.Add(2, "Omnicon");
            devices.Add(3, "Aquameter");


            Console.WriteLine("Antech'in ölç-" +
                "üm cihazları : ");
            for (int i = 0; i < devices.KeyLength; i++)
            {
                Console.WriteLine("{0} : {1}", devices.Keys[i], devices.Values[i]);
            }

        }
    }
}
