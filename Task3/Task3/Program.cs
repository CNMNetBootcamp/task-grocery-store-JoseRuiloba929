using System;



namespace Task3

{
    class Program
    {
        static void Main(string[] args)
        {

            //setup

            int dailyTotBottles = 0;
            Single wklytotBottles = 0;
            Double wklytotPaid = 0;
            string validateEntry = string.Empty;
            bool IsString = true;
            Double bottleCost = .10;

            //input
            for (int day = 1; day < 8; day++)
            {

                do
                {
                    Console.WriteLine("Enter the total bottles for day " + day);
                    validateEntry = Console.ReadLine();
                    IsString = int.TryParse(validateEntry, out dailyTotBottles);
                    if (!(IsString))
                    {
                        Console.WriteLine("You entered a non numeric number, Please try again");
                    }

                } while (!(IsString));

                //process
                wklytotBottles = dailyTotBottles + wklytotBottles;
            }

            //process

            // TODO: Refactor without magic numbers
            wklytotPaid = wklytotBottles * bottleCost;
            //output

            Console.WriteLine("The total number bottles for the week is " + wklytotBottles + " the ammont paid is " + wklytotPaid + " dollars");
            Console.ReadLine();
        }
    }
}