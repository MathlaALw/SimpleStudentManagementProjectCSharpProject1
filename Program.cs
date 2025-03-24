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
                //Menu System
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

        //Add a new student record (Name, Age, Marks)
        static void AddNewStudent()
        {


            char doAgain;
            do
            {
                //ask user for  number of student .
                Console.WriteLine("\nEnter Number of students to add:");
                int numberOfStudent = int.Parse(Console.ReadLine());
                // check the total student if less than or equal the maxStudent (10) .
                if (numberOfStudent + StudentCounter <= maxStudent)
                {
                    // start looping from student counter until the total of  student counter and number of student witch the user entered 
                    for (int i = StudentCounter; i < StudentCounter + numberOfStudent; i++)
                    {
                        //ask for student name
                        Console.WriteLine("Enter Student Name:");
                        names[i] = Console.ReadLine();
                        //keep ask user for student marks until the user take number in range of (0-100).
                        do
                        {
                            //ask for student marks
                            Console.WriteLine("Enter Student Marks: ");
                            marks[i] = int.Parse(Console.ReadLine());
                            if (marks[i] < 0 || marks[i] > 100) //show message if The mark out of range .
                            {
                                Console.WriteLine("invalid marks.The mark should be between ( 0 - 100 ).");
                            }


                        } while (marks[i] < 0 || marks[i] > 100);

                        //keep ask user for student Ages until the user take number less than 21.
                        do
                        {
                            Console.WriteLine("Enter Student Age : ");
                            ages[i] = int.Parse(Console.ReadLine());
                            if (ages[i] < 21) // show message if ages[i] less than 21
                            {
                                Console.WriteLine("you cont add age less than 21 .");

                            }

                        } while (ages[i] < 21);

                        //insert date direct in dates array.
                        dates[i] = DateTime.Now;
                        // the massege show to user if the all name ,marks and age saved in arrays.
                        Console.WriteLine("Student Added Successfully .");
                    }
                    //Student counter add the number of student that we asked in the first of program
                    StudentCounter = StudentCounter + numberOfStudent;
                }

                else if (StudentCounter == maxStudent)  //Maximum number of students reached
                {
                    Console.WriteLine("Maximum number of students reached. No more students can be added.");
                }
                else //Show the remaining space if user enter number greater than the remaining space
                {
                    Console.WriteLine($"Invalid input . the remaining space is {maxStudent - StudentCounter}");


                }
                //keep ask user for adding more student until the user want to exit the first Requirement(Add new student).
                Console.WriteLine("\n Do you want to add more students? (y/n) \n");
                doAgain = Console.ReadKey().KeyChar;

            } while (doAgain == 'y' || doAgain == 'Y');





        }


        //View all students (names,Ages, marks enrollment date)
        static void ViewAllStudent()
        {
            if (StudentCounter == 0) // if student counter == 0 show massege "No student record found.".
            {
                Console.WriteLine("No student record found.");

            }
            else // show the student detailes from all arrays.
            {
                for (int i = 0; i < StudentCounter; i++) //start looping from 0 until reach all student that are available in array
                {

                    Console.WriteLine("Student Name : " + names[i]);
                    Console.WriteLine("Student Mark : " + marks[i]);
                    Console.WriteLine("Student Age : " + ages[i]);
                    Console.WriteLine("Student Enrllment Date : " + dates[i]);




                }
            }

        }
        //Find a student by name
        static void FindStudent()
        {
            bool found; // flag to know if there is a result or not
            do // keep asking user for name until found.
            {

                //ask user for student name .
                Console.Write("Enter student name: ");
                string searchName = Console.ReadLine();
                searchName.ToLower(); // convert the student name in lowercase
                found = false; //initialize found


                for (int i = 0; i < StudentCounter; i++) //start looping from 0 until reach all student that are available in array
                {
                    string LowerNames = names[i].ToLower();// convert the student name in lowercase ( names array)

                    if (LowerNames == searchName) //compar between user entered name and the name in array (if are match )
                    {
                        //show the students detailes
                        Console.WriteLine("Student Name : " + names[i]);
                        Console.WriteLine("Student Mark : " + marks[i]);
                        Console.WriteLine("Student Age : " + ages[i]);
                        Console.WriteLine("Student Enrllment Date : " + dates[i]);
                        found = true;
                        break;
                    }

                }

                if (!found) //Show "Not found. Try again." if names are not match
                {
                    Console.WriteLine("Not found. Try again.");
                }
            } while (!found);
        }
        //Calculate the class average
        static void CalculateAverage()
        {
            if (StudentCounter == 0) // if student counter == 0 show massege "No student record found.".
            {
                Console.WriteLine("No student record found.");

            }
            double sum = 0; //Declare and initialize sum
            for (int i = 0; i < StudentCounter; i++) //start looping from 0 until reach all student that are available in array
            {
                sum = sum + marks[i]; // sum the marks
            }
            double average = sum / StudentCounter; //Declare and assign value to Average
            Console.WriteLine("The class average is: " + Math.Round(average, 2)); 

        }
        //Find the top-performing student
        static void FindTopPerformingStudent()
        {

            if (StudentCounter == 0) // if student counter == 0 show massege "No student record found.".
            {
                Console.WriteLine("No students available.");

            }

            int topIndex = 0;//Declare and initialize topIndex to store the index of the highest student mark (topIndex =0)
            for (int i = 1; i < StudentCounter; i++) //start looping from 1 until reach all student that are available in array
            {
                //        1  >         0   at the first
                if (marks[i] > marks[topIndex]) // compare between the first mark i=1 with marks[topIndex] (topIndex = 0)
                {
                    topIndex = i; // take the large mark index

                }
            }
            //show the top-performing students detailes 
            Console.WriteLine(names[topIndex]);
            Console.WriteLine(marks[topIndex]);
            Console.WriteLine(ages[topIndex]);
            Console.WriteLine(dates[topIndex]);


        }
        //Sort students by marks (Descending Order)
        static void SortStudents()
        {
            //Declare new arrays to sort data 
            string[] sortedName = new string[StudentCounter];
            double[] sortedMarks = new double[StudentCounter];
            int[] sortedAges = new int[StudentCounter];
            DateTime[] sortedDates = new DateTime[StudentCounter];

            for (int i = 0; i < StudentCounter; i++)//start looping from 0 until reach all student that are available in array
            {
                //Copy the value from the orginal array(ex:names[]) to the new array (ex:sortedNames[])
                sortedName[i] = names[i];
                sortedMarks[i] = marks[i];
                sortedAges[i] = ages[i];
                sortedDates[i] = dates[i];
            }
            for (int i = 0; i < StudentCounter; i++) //start looping from 0 until reach all student that are available in array
            { 

                for (int j = i + 1; j < StudentCounter; j++) //start looping from 1 until reach all student that are available in array to compare
                { 

                    if (sortedMarks[i] < sortedMarks[j]) //Compare the first index with the second index start from sortedMarks[0] < sortedMarks[1]
                    {
                        //swap marks
                        double mark = sortedMarks[i];
                        sortedMarks[i] = sortedMarks[j];
                        sortedMarks[j] = mark;

                        //swap names
                        string Name = sortedName[i];
                        sortedName[i] = sortedName[j];
                        sortedName[j] = Name;

                        //swap ages
                        int Age = sortedAges[i];
                        sortedAges[i] = sortedAges[j];
                        sortedAges[j] = Age;

                        //swap enrollment dates
                        DateTime Date = sortedDates[i];
                        sortedDates[i] = sortedDates[j];
                        sortedDates[j] = Date;

                    }

                }   
            }
            for (int i = 0; i < StudentCounter; i++) //start looping from 0 until reach all student that are available in array to view the sorted arrays
            {
                Console.WriteLine("Student Name : " + sortedName[i]);
                Console.WriteLine("Student Mark : " + sortedMarks[i]);
                Console.WriteLine("Student Age : " + sortedAges[i]);
                Console.WriteLine("Student Enrllment Date : " + sortedDates[i]);
            }
        }


        //Delete a student record
        static void DeleteStudent()
         {
            int indexToDelete;// declare variable indexToDelete 
            do // keep asking user for name to deleted until found.
            {
                Console.Write("Enter student name to delete: ");
                string deleteName = Console.ReadLine();
                deleteName.ToLower(); //convert the user input to lowercase

                indexToDelete = -1;  //initialize 
                for (int i = 0; i < StudentCounter; i++)//start looping from 0 until reach all student that are available in array
                {
                    string LowerNames = names[i].ToLower();//convert the names in names array to lowercase
                    if (LowerNames == deleteName)
                    {
                        indexToDelete = i; //assign index of name in indexToDelete

                    }
                    else  //(indexToDelete == -1)
                    {
                        Console.WriteLine("Student not found.");

                    }
                }



            } while (indexToDelete == -1);


            
            for (int i = indexToDelete; i < StudentCounter - 1; i++) //start looping from indexToDelete until (reach all student that are available in array -1)
            {
                // Shift all elements to left
                names[i] = names[i + 1];
                ages[i] = ages[i + 1];
                marks[i] = marks[i + 1];
                dates[i] = dates[i + 1];
            }

            StudentCounter = StudentCounter - 1; //decrese  Student Counter by 1
            Console.WriteLine("Student deleted successfully.");

        }


    }
}
