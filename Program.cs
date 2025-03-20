namespace SimpleStudentManagementProjectCSharpProject1
{
    internal class Program
    {

        static double[] marks = new double[10];
        static int[] Ages = new int[10];
        static string[] names = new string[10];
        static DateTime[] dates = new DateTime[10];
        static int StudentCounter = 0;
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

          

        }

        static void ViewAllStudent()
        {



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
