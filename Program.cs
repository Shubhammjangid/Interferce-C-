using System;

namespace Interface; 

    internal class Program
    {
        static void Main(string[] args)
        {
            Tata tata = new Tata();

            // user input for car Name
            Console.WriteLine("Enter your carname? :");
            string ModelName = Console.ReadLine();

            //user input for average of car
            Console.WriteLine("How many kilometer does your car has travelled: ");
            int A= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much liter of Petrol/Diesel(lt) taken to travel: ");
            int B = Convert.ToInt32(Console.ReadLine());

            //Final output
            Console.WriteLine($"your {tata.Describe(ModelName)} Car has average of {tata.Average(A,B)} kmpl");
        }
    }
