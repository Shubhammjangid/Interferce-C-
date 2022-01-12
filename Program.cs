using System;

namespace Interface; 

    internal class Program
    {
        static void Main(string[] args)
        {
            Tata tata = new Tata();

            // Console.WriteLine("Enter your carname? :");
            // string ModelName = Convert.ToString(Console.ReadLine());

            //user input for average of car
            Console.WriteLine("How many kilometer does your car has travelled: ");
            int A= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much liter of Petrol/Diesel(lt) taken to travel: ");
            int B = Convert.ToInt32(Console.ReadLine());



            int Result = tata.Average(A,B);
            //Final output
            Console.WriteLine($"your {tata.Describe("Tata")} Car has mileage of {Result} kmpl");

            if(Result<10){
                Console.WriteLine($"low mileage : {Result}");
            }
            else{
                Console.WriteLine($"Good mileage : {Result}");
            }

            
        }
    }
