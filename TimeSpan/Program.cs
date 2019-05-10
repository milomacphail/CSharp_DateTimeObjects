using System;

namespace TimeSpan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creating TimeSpan objects
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromDays(1);

            var start = DateTime.Now;
            var end = DateTime.NowAddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes" + timeSpan.TotalMinutes);

            // Add 
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.From(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.From(2)));


            //Parse
            Console.WriteLine(timeSpan.ToString());
            Console.WriteLine(timeSpan.Parse("01:02:03"));

        }
    }
