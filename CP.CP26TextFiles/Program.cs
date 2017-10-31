using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP26TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();

            //Example2();

            Example3();

            //Example4();
        }

        private static void Example1()
        {
            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C:\andy.wyatt\WriteLines.txt", lines);
        }

        private static void Example2()
        {
            // Example #2: Write one string to a text file.
            string text = "The cat sat on the mat" + Environment.NewLine + Environment.NewLine;
            text += "This is a really nice story" + Environment.NewLine + Environment.NewLine;
            text += "Written by Jacqui Age 2";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\andy.wyatt\WriteText.txt", text);
        }

        private static void Example3()
        {
            // Example #3: Write only some strings in an array to a file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            {
                string input = string.Empty;
                do
                {
                    Console.WriteLine("Type text (exit to exit):");
                    input = Console.ReadLine();

                    file.WriteLine(input);
                } while (input.ToLower() != "exit");
            }
        }

        private static void Example4()
        {
            
        }
    }
}
