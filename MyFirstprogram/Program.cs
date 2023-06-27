using System;

namespace MyFirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int lungime;
            int latime;

            Console.WriteLine("Introduceti lungimea");
            lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latime");
            latime = int.Parse(Console.ReadLine());

            int ariCamerei = lungime * latime;

            Console.WriteLine("Aria camerei este "  + ariCamerei);

        }
    }
}