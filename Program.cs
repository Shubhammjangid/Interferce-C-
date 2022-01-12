using System;

namespace Interface; 

    internal class Program
    {
        static void Main(string[] args)
        {
            Tata tata = new Tata();
            Hyundai hyun = new Hyundai();
            Console.WriteLine(tata.Describe("Nano"));
            Console.WriteLine(tata.CarColor("Red"));
            Console.WriteLine($"The Car has average of {tata.Average(12000,120)} kmpl");
            Console.WriteLine(hyun.Describe("Nano"));
            Console.WriteLine(hyun.CarColor("Red"));
            Console.WriteLine($"The Car has average of {tata.Average(18000,120)} kmpl");
        }
    }
