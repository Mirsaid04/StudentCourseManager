using StudentCourseManager.Classes;

namespace StudentCourseManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesOrno = "";
            do
            {
                ValueManipulator valueManipulator = new ValueManipulator();
                valueManipulator.ShowMenu();

                Course course = new Course();

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        course.enrollTheCourse();
                        break;

                    case 2:
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("You want to check all your courses");
                        break;
                    case 4:
                        Console.WriteLine("You want to exit");
                        break;

                    default:
                        Console.WriteLine("You entered invalid input");
                        break;
                }
                Console.Write("Do you want to contine [y]/[n]: ");
                yesOrno = Console.ReadLine();   
            } while (yesOrno == "y");
        }
    }
}