namespace grading_system
{
    internal class Program
    {
        static void Main()
        {
            bool hasName = false;
            bool hasProgram = false;
            bool hasCourse = false;
            bool hasCollege = false;
            string name = "";
            string program = "";
            string course = "";
            string college = "";

            // Welcome Message
            Console.WriteLine("------------------");
            Console.WriteLine("| GRADING SYSTEM |");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Developed By: John Marky Natividad\n" +
                              "              BS ComSci 1-A\n" +
                              "              October 14, 2024\n\n");

            // Ask for user's  information
            while (!hasName)
            {
                if (name.Length == 0)
                {
                    Console.Write("What is your name? ");
                    name = Console.ReadLine() ?? "";
                }
                else hasName = true;
            }
            while (!hasProgram)
            {
                if (program.Length == 0)
                {
                    Console.Write("What is your program? ");
                    program = Console.ReadLine() ?? "";
                }
                else hasProgram = true;
            }
            while (!hasCourse)
            {
                if (course.Length == 0)
                {
                    Console.Write("What is your course? ");
                    course = Console.ReadLine() ?? "";
                }
                else hasCourse = true;
            }
            while (!hasCollege)
            {
                if (college.Length == 0)
                {
                    Console.Write("What is your college? ");
                    college = Console.ReadLine() ?? "";
                }
                else hasCollege = true;
            }

            // Choose an option
            Console.WriteLine("\nChoose An Option:\n\t[ 1 ] - Input a numerical grade (50-100) and output the corresponding grade point and description.\n\t[ 2 ] - Display the full grading scale.\n\t[ 3 ] - Exit the program");

            // Switch between selections
            Console.Write("Your Option: ");
            switch (Console.ReadLine() ?? "")
            {
                // For case 1 - Calculate Grade
                case "1":
                    {
                        Console.Write("\nInput grade: ");
                        decimal grade = decimal.Parse(Console.ReadLine() ?? "");
                        decimal gradePoint = 0;
                        string gradeDesc = "";

                        if (grade >= 50 && grade <= 100)
                        {
                            // Caclulating grade
                            if (grade >= 99 && grade <= 100)
                            {
                                gradePoint = 1.00m;
                                gradeDesc = "Excellent";
                            }
                            else if (grade >= 96 && grade <= 98)
                            {
                                gradePoint = 1.25m;
                                gradeDesc = "Excellent";
                            }
                            else if (grade >= 93 && grade <= 95)
                            {
                                gradePoint = 1.50m;
                                gradeDesc = "Very Satisfactory";
                            }
                            else if (grade >= 90 && grade <= 92)
                            {
                                gradePoint = 1.75m;
                                gradeDesc = "Very Satisfactory";
                            }
                            else if (grade >= 87 && grade <= 89)
                            {
                                gradePoint = 2.00m;
                                gradeDesc = "Satisfactory";
                            }
                            else if (grade >= 84 && grade <= 86)
                            {
                                gradePoint = 2.25m;
                                gradeDesc = "Satisfactory";
                            }
                            else if (grade >= 81 && grade <= 83)
                            {
                                gradePoint = 2.50m;
                                gradeDesc = "Fairly Satisfactory";
                            }
                            else if (grade >= 78 && grade <= 80)
                            {
                                gradePoint = 2.75m;
                                gradeDesc = "Fairly Satisfactory";
                            }
                            else if (grade >= 75 && grade <= 77)
                            {
                                gradePoint = 3.00m;
                                gradeDesc = "Passed";
                            }
                            else if (grade >= 70 && grade <= 74)
                            {
                                gradePoint = 4.00m;
                                gradeDesc = "Conditional Failure";
                            }
                            else if (grade <= 69)
                            {
                                gradePoint = 5.00m;
                                gradeDesc = "Failed";
                            }

                            // Output grade
                            Console.WriteLine($"\n{name}, a student from {program} under the {college}, enrolled in {course}, received a grade of {grade}. The corresponding grade point is {gradePoint}, which is described as {gradeDesc}.");
                        }
                        else
                        {
                            // End program if invalid grade
                            Console.WriteLine("\nInvalid input. Numerical grade must be between 50 and 100.\nExiting the program. Goodbye!");
                        }
                        break;
                    }
                //For case 2 - Display Grade Scale
                case "2":
                    {
                        Console.WriteLine("\n-------------------------------------------------------\n" +
                                            "| Numerical Grade | Grade Point |     Description     |\n" +
                                            "-------------------------------------------------------\n" +
                                            "|      99-100     |    1.00     |      Excellent      |\n" +
                                            "|      96-98      |    1.25     |      Excellent      |\n" +
                                            "|      93-95      |    1.50     |  Very Satisfactory  |\n" +
                                            "|      90-92      |    1.75     |  Very Satisfactory  |\n" +
                                            "|      87-89      |    2.00     |     Satisfactory    |\n" +
                                            "|      84-86      |    2.25     |     Satisfactory    |\n" +
                                            "|      81-83      |    2.50     | Fairly Satisfactory |\n" +
                                            "|      78-80      |    2.75     | Fairly Satisfactory |\n" +
                                            "|      75-77      |    3.00     |        Passed       |\n" +
                                            "|      70-74      |    4.00     | Conditional Failure |\n" +
                                            "|     69 below    |    5.00     |        Failed       |\n" +
                                            "-------------------------------------------------------\n");
                        break;
                    }
                //For case 3 - Exit
                case "3":
                    {
                        break;
                    }
                //Default, executes when input is not in a selection
                default:
                    {
                        Console.WriteLine("\nInvalid selection. Please choose a valid option from the menu (1, 2, or 3). Exiting the program. Goodbye!");
                        break;
                    }
            }
        }
    }
}