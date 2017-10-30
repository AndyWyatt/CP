using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP24Collections
{
    class Program
    {
        static Queue<Student> vaccinationQueue = new Queue<Student>();

        static void Main(string[] args)
        {
            int option = 0;
            const int exitOption = 4;

            do
            {
                Console.WriteLine("1) Add a student");
                Console.WriteLine("2) Vaccinate a student");
                Console.WriteLine("3) Print all students");
                Console.WriteLine("----------------------");
                Console.WriteLine("4) Exit");

                Console.Write("Option? ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddStudentToVaccinationQueue();
                        break;
                    case 2:
                        VaccinateAStudent();
                        break;
                    case 3:
                        OutputVacinationQueue();
                        break;
                    case exitOption:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("This is an unknown option");
                        break;
                }
            } while (option != exitOption);
        }

        private static void AddStudentToVaccinationQueue()
        {
            string forename = string.Empty;
            string surname = string.Empty;

            Console.WriteLine("Student's forename?");
            forename = Console.ReadLine();

            Console.WriteLine("Student's surname?");
            surname = Console.ReadLine();

            Student student = new Student(forename, surname);
            vaccinationQueue.Enqueue(student);
        }

        private static void VaccinateAStudent()
        {
            if (vaccinationQueue.Count > 0)
            {
                Student student = vaccinationQueue.Dequeue();
                student.Vacinate();
                Console.WriteLine("Student vaccinated - OUCH!");
                Console.WriteLine(student); 
            }
            else
            {
                Console.WriteLine("No one in the queue!");
            }
        }

        private static void OutputVacinationQueue()
        {
            Console.WriteLine("Students in the queue:-");
            foreach (Student student in vaccinationQueue)
            {
                Console.WriteLine(student);
            }
        }
    }
}
