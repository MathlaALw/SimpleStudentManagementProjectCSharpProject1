namespace SimpleStudentManagementProjectCSharpProject1
{
    internal class Program
    {

        static double[] marks = new double[10];
        static int[] Ages = new int[10];
        static string[] names = new string[10];
        static DateTime[] dates = new DateTime[10];
        static int StudentCounter = 0;
        static int StudentNow;
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


            StudentNow = 3;
            char doAgain;
            do
            {
                Console.WriteLine("\nEnter Number of student to add :");
                int n = int.Parse(Console.ReadLine());

                if (n <= StudentNow)
                {
                    for (int i = 0; i <= n - 1; i++)
                    {
                        StudentCounter++;
                        Console.WriteLine("Enter Student Names : ");
                        names[i] = Console.ReadLine();
                        Console.WriteLine("Enter Student Marks : ");
                        marks[i] = int.Parse(Console.ReadLine());
                        if (marks[i] < 0 || marks[i] > 100)
                        {
                            Console.WriteLine("invalid marks Enter Student Mark Again : ");
                            marks[i] = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Enter Student Age : ");
                        Ages[i] = int.Parse(Console.ReadLine());
                        if (Ages[i] < 21)
                        {
                            Console.WriteLine("you cont add age less than 21 Enter Student Age Again :");
                            Ages[i] = int.Parse(Console.ReadLine());
                        }


                        dates[i] = DateTime.Now;




                    }
                    StudentNow = StudentNow - n;
                    // Console.WriteLine("The array have now " + StudentNow + " Space");
                }
                else if (StudentNow == 3)
                {
                    Console.WriteLine("The array is full ");
                }
                else
                {
                    Console.WriteLine("The array have now " + StudentNow + " Space");
                }

                // StudentNow = StudentNow;
                Console.WriteLine(" \nDo you want another operation ? y / n \n");
                doAgain = Console.ReadKey().KeyChar;

            } while (doAgain == 'y' || doAgain == 'Y');

            //Console.WriteLine("\ngoodbye");

        }

        static void ViewAllStudent()
        {

            for (int i = 0; i < StudentCounter; i++)
            {

                Console.WriteLine(names[i]);
                Console.WriteLine(marks[i]);
                Console.WriteLine(Ages[i]);
                Console.WriteLine(dates[i]);




            }


        }

        static void FindStudent()
        {
          
        }

         static void CalculateAverage()
        {



         }

        static void FindTopPerformingStudent()
         {



         }
        static void SortStudents()
         {



          }
        static void DeleteStudent()
         {



            }


    }
}
