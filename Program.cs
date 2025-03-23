namespace SimpleStudentManagementProjectCSharpProject1
{
    internal class Program
    {

        static double[] marks = new double[10];
        static int[] ages = new int[10];
        static string[] names = new string[10];
        static DateTime[] dates = new DateTime[10];
        static int StudentCounter = 0;
        static int maxStudent = 10;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Find a student");
                Console.WriteLine("4. Calculate the class average");
                Console.WriteLine("5. Find the top-performing student");
                Console.WriteLine("6. Sort students by marks");
                Console.WriteLine("7. Delete a student record ");
                Console.WriteLine("8. Exit");


                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddNewStudent(); break;
                    case 2: ViewAllStudent(); break;
                    case 3: FindStudent(); break;
                    case 4: CalculateAverage(); break;
                    case 5: FindTopPerformingStudent(); break;
                    case 6: SortStudents(); break;
                    case 7: DeleteStudent(); break;
                    case 8: return;

                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.WriteLine("Press any key ");
                Console.ReadLine();
            }
        }


        static void AddNewStudent()
        {

            char doAgain;
            do
            {
                Console.WriteLine("\nEnter Number of students to add:");
                int numberOfStudent = int.Parse(Console.ReadLine());

                if (numberOfStudent + StudentCounter <= maxStudent)
                {
                    for (int i = StudentCounter; i < StudentCounter + numberOfStudent; i++)
                    {
                        Console.WriteLine("Enter Student Name:");
                        names[i] = Console.ReadLine();

                        Console.WriteLine("Enter Student Marks: ");
                        marks[i] = int.Parse(Console.ReadLine());
                        if (marks[i] <= 0 || marks[i] >= 100)
                        {
                            Console.WriteLine("invalid marks Enter Student Mark Again : ");
                            marks[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Enter Student Age : ");
                        ages[i] = int.Parse(Console.ReadLine());
                        if (ages[i] < 21)
                        {
                            Console.WriteLine("you cont add age less than 21 Enter Student Age Again :");
                            ages[i] = int.Parse(Console.ReadLine());
                        }


                        dates[i] = DateTime.Now;

                        Console.WriteLine("Student Added Successfully");
                    }
                    StudentCounter = StudentCounter + numberOfStudent;
                }
                else if (StudentCounter == maxStudent)
                {
                    Console.WriteLine("Maximum number of students reached. No more students can be added.");
                }
                else
                {
                    Console.WriteLine($"Invalid input. you cant enter number greater then  {maxStudent} the remainnig space is {maxStudent - StudentCounter}");


                }

                Console.WriteLine("\nDo you want to add more students? (y/n)");
                doAgain = Console.ReadKey().KeyChar;

            } while (doAgain == 'y' || doAgain == 'Y');


        }

        

        static void ViewAllStudent()
        {
            if (StudentCounter == 0)
            {
                Console.WriteLine("No student record found.");

            }
            else
            {
                for (int i = 0; i < StudentCounter; i++)
                {

                    Console.WriteLine(names[i]);
                    Console.WriteLine(marks[i]);
                    Console.WriteLine(ages[i]);
                    Console.WriteLine(dates[i]);




                }
            }

        }

        static void FindStudent()
        {
            bool found;
            do
            {


                Console.Write("Enter student name: ");
                string searchName = Console.ReadLine();
                searchName.ToLower();
                found = false;


                for (int i = 0; i < StudentCounter; i++)
                {
                    string LowerNames = names[i].ToLower();

                    if (LowerNames == searchName)
                    {

                        Console.WriteLine(names[i]);
                        Console.WriteLine(marks[i]);
                        Console.WriteLine(ages[i]);
                        Console.WriteLine(dates[i]);
                        found = true;
                        break;
                    }

                }

                if (!found)
                {
                    Console.WriteLine("Not found. Try again.");
                }
            } while (!found);
        }

         static void CalculateAverage()
        {
            if (StudentCounter == 0)
            {
                Console.WriteLine("No student record found.");

            }
            double sum = 0;
            for (int i = 0; i < StudentCounter; i++)
            {
                sum = sum + marks[i];
            }
            double average = sum / StudentCounter;
            Console.WriteLine("The class average is: " + Math.Round(average));

        }

        static void FindTopPerformingStudent()
         {

            if (StudentCounter == 0)
            {
                Console.WriteLine("No students available.");

            }

            int topIndex = 0;
            for (int i = 1; i < StudentCounter; i++)
            {
                if (marks[i] > marks[topIndex])
                {
                    topIndex = i;

                }
            }
            Console.WriteLine(names[topIndex]);
            Console.WriteLine(marks[topIndex]);
            Console.WriteLine(ages[topIndex]);
            Console.WriteLine(dates[topIndex]);


        }
        static void SortStudents()
         {



          }
        static void DeleteStudent()
         {



            }


    }
}
