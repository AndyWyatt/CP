using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP22MemoryCollections
{
    class Program
    {
        static void Main(string[] args)
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
