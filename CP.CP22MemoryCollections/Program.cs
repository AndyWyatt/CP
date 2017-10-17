using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP22MemoryCollections
{
    class Record
    {
        public DateTime LogTime { get; private set; }
        public string WhatItIs { get; set; }
        public string Fault { get; set; }
        public string LoggedBy { get; set; }

        private Record()
        {

        }

        public Record(string whatItIs, string fault, string loggedBy) : this()
        {
            LogTime = DateTime.Now;
            WhatItIs = whatItIs;
            Fault = fault;
            LoggedBy = loggedBy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArraysExample();

            Console.WriteLine("Who are you?");
            string userName = Console.ReadLine();

            Console.WriteLine("How many items to log");
            int noOfItemsToLog = int.Parse(Console.ReadLine());

            Record[] records = new Record[noOfItemsToLog];
            for (int i = 0; i < noOfItemsToLog; i++)
            {
                Console.WriteLine("Item " + (i + 1));
                Console.WriteLine("What is it?");
                string whatItIs = Console.ReadLine();
                Console.WriteLine("What's wrong?");
                string whatsWrong = Console.ReadLine();

                records[i] = new Record(whatItIs, whatsWrong, userName);
            }

            Console.WriteLine("All items logged:-");
            foreach (Record record in records)
            {
                Console.WriteLine(
$@"date logged    = { record.LogTime }
logged by      = { record.LoggedBy }
item           = { record.WhatItIs }
what's wrong   = { record.Fault }");
                Console.WriteLine();
            }
        }

        private static void ArraysExample()
        {
            int[] ages =
                        {
                12,
                12,
                13,
                14,
                15
            };

            foreach (int age in ages)
            {
                Console.WriteLine("age -> " + age);
            }
            Console.WriteLine($"There are {ages.Length} ages");

            int[,] numberOfStudentsInMB319EachHourDuringTheWeek = new int[7, 5];
            // Monday
            numberOfStudentsInMB319EachHourDuringTheWeek[0, 0] = 0;
            numberOfStudentsInMB319EachHourDuringTheWeek[1, 0] = 10;
            numberOfStudentsInMB319EachHourDuringTheWeek[2, 0] = 10;
            numberOfStudentsInMB319EachHourDuringTheWeek[3, 0] = 0;
            numberOfStudentsInMB319EachHourDuringTheWeek[4, 0] = 2;

            // Tuesday
            numberOfStudentsInMB319EachHourDuringTheWeek[0, 1] = 1;
            numberOfStudentsInMB319EachHourDuringTheWeek[1, 1] = 20;

            Console.WriteLine($"2nd hour on Tuesday = {numberOfStudentsInMB319EachHourDuringTheWeek[1, 1]}");
            Console.WriteLine("length = " + numberOfStudentsInMB319EachHourDuringTheWeek.Length);

            for (int dayNo = 0; dayNo < 5; dayNo++)
            {
                for (int hourNo = 0; hourNo < 7; hourNo++)
                {
                    Console.Write(numberOfStudentsInMB319EachHourDuringTheWeek[hourNo, dayNo] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
