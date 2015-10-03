using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ReportCard
{
    class ReportCard
    {
        static void Main(string[] args)
        {
            string dogName = "Mary";
            string numberOfDaysString = "asdf";
            int numberOfDays = 0;
            int dayCount = 1;
            string ratingString = "asdf";
            int rating = 0;
            int ratingAccumulator = 0;
            string EXIT = "ZZZ";
            string EXITlower = "zzz";

            Console.Title = "The Barking Lot Report Card Generator";

            Console.Write("Welcome to The Barking Lot's report card generator.\nPlease enter the name of the dog.\nOtherwise, if you would like to exit the application, enter ZZZ. >> ");
            dogName = Console.ReadLine();
            Thread.Sleep(1000);
            Console.Clear();
            while (dogName != EXIT && dogName != EXITlower)
            {
                Console.Write("Please enter the number of days that " + dogName + " stayed at The Barking Lot.\nReport cards will be generated for a maximum of 21 days. >> ");
                numberOfDaysString = Console.ReadLine();
                numberOfDays = int.Parse(numberOfDaysString);
                while (numberOfDays < 1 || numberOfDays > 21)
                {
                    Console.Write("Please re-enter the number of days that " + dogName + " stayed.\nThis must be a value from 1 through 21. >> ");
                    numberOfDaysString = Console.ReadLine();
                    numberOfDays = int.Parse(numberOfDaysString);

                }
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Please enter a rating from 1 through 5 of " + dogName + "'s:");
                Thread.Sleep(500);
                Console.WriteLine("\tAppetite (how well they ate)");
                Thread.Sleep(500);
                Console.WriteLine("\tAppearance (how healthy they appeared)");
                Thread.Sleep(500);
                Console.WriteLine("\tDemeanor (how friendly they were)");
                Thread.Sleep(500);
                Console.WriteLine("For each of their " + numberOfDays + " day-stay at The Barking Lot.");
                Thread.Sleep(1000);
                Console.Write("Press any key to begin the report...");
                Console.ReadKey();
                Console.Clear();
                while (dayCount <= numberOfDays)
                {
                    Console.Write("Please enter " + dogName + "'s appetite for day " + dayCount + ". >> ");
                    ratingString = Console.ReadLine();
                    rating = int.Parse(ratingString);
                    Thread.Sleep(1000);
                    while (rating < 1 || rating > 5)
                    {
                        Console.WriteLine("Please re-enter the rating for appetite.\nThe value must be 1, 2, 3, 4, or 5. >> ");
                        ratingString = Console.ReadLine();
                        rating = int.Parse(ratingString);
                        Thread.Sleep(1000);
                    }
                    ratingAccumulator = ratingAccumulator + rating;
                    Console.Write("Please enter " + dogName + "'s appearance for day " + dayCount + ". >> ");
                    ratingString = Console.ReadLine();
                    rating = int.Parse(ratingString);
                    Thread.Sleep(1000);
                    while (rating < 1 || rating > 5)
                    {
                        Console.WriteLine("Please re-enter the rating for appearance.\nThe value must be 1, 2, 3, 4, or 5. >> ");
                        ratingString = Console.ReadLine();
                        rating = int.Parse(ratingString);
                        Thread.Sleep(1000);
                    }
                    ratingAccumulator = ratingAccumulator + rating;
                    Console.Write("Please enter " + dogName + "'s demeanor for day " + dayCount + ". >> ");
                    ratingString = Console.ReadLine();
                    rating = int.Parse(ratingString);
                    Thread.Sleep(1000);
                    while (rating < 1 || rating > 5)
                    {
                        Console.WriteLine("Please re-enter the rating for demeanor.\nThe value must be 1, 2, 3, 4, or 5. >> ");
                        ratingString = Console.ReadLine();
                        rating = int.Parse(ratingString);
                        Thread.Sleep(1000);
                    }
                    ratingAccumulator = ratingAccumulator + rating;
                    Console.WriteLine((numberOfDays - dayCount) + " more day(s) to go!");
                    dayCount++;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Thread.Sleep(1000);
                Console.WriteLine("Thanks! The total score for " + dogName + "'s " + numberOfDays + " day stay at The Barking Lot is " + ratingAccumulator + " out of a possible " + (numberOfDays * 15) + " points.");
                Thread.Sleep(1000);
                rating = 0;
                ratingAccumulator = 0;
                numberOfDays = 0;
                dayCount = 1;
                Console.Write("Please enter the name of the next dog. Otherwise, if you would like to exit the application, enter ZZZ. >> ");
                dogName = Console.ReadLine();
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.Write("Thanks for using The Barking Lot’s report card generator!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
