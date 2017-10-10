using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP16IterationForAndForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecapActivity();

            //ForLoopExample();

            ForEachLoopExample();
        }

        private static void ForEachLoopExample()
        {
            int[] ages = {
                37,
                25,
                16,
                18,
                18,
                17,
                16,
                19,
                16,
                17,
                17,
                16,
                16
            };

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }

            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
        }

        private static void ForLoopExample()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("I can count " + i);
            }

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("I can count down " + i);
            }

            int[] ages = {
                18,
                17,
                16,
                17,
                18
            };
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + " * 2 = " + i * 2);
            }
        }

        private static void RecapActivity()
        {
            int[] ages = {
                18,
                17,
                16
            };

            List<int> ageList = new List<int>();
            ageList.Add(18);
            ageList.Add(17);
            ageList.Add(16);

            Console.WriteLine("1st in ages = " + ages[0]);
            Console.WriteLine("1st in ageList = " + ageList[0]);
        }
    }
}
