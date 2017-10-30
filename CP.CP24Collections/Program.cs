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
        static Queue<Plane> planesAtTerminal = new Queue<Plane>();

        static void Main(string[] args)
        {
            int option = 0;
            const int exitOption = 7;

            do
            {
                Console.WriteLine("1) Add a student");
                Console.WriteLine("2) Vaccinate a student");
                Console.WriteLine("3) Print all students");
                Console.WriteLine("----------------------");
                Console.WriteLine("4) Queue a plane");
                Console.WriteLine("5) Dequeue a plane");
                Console.WriteLine("6) Print all planes in queue");
                Console.WriteLine("----------------------");
                Console.WriteLine($"{exitOption}) Exit");

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
                    case 4:
                        QueuePlane();
                        break;
                    case 4:
                        DequeuePlane();
                        break;
                    case 4:
                        PrintPlanesInQueue();
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

        private static void QueuePlane()
        {
            string pilotName = string.Empty;
            int portNo = 0;

            Console.WriteLine("Pilot's name?");
            pilotName = Console.ReadLine();

            Console.WriteLine("Port No?");
            portNo = int.Parse(Console.ReadLine());

            Plane plane = new Plane(pilotName, portNo);
            planesAtTerminal.Enqueue(plane);
        }

        private static void DequeuePlane()
        {
            if (planesAtTerminal.Count > 0)
            {
                Plane plane = planesAtTerminal.Dequeue();
                Console.WriteLine("Plane left terminal!");
                Console.WriteLine(plane);
            }
            else
            {
                Console.WriteLine("No plane at terminal!");
            }
        }

        private static void PrintPlanesInQueue()
        {
            Console.WriteLine("Planes at terminal");
            foreach (Plane plane in planesAtTerminal)
            {
                Console.WriteLine(plane);
            }
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
