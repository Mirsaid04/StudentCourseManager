using StudentCourseManager.Classes;

namespace StudentCourseManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1118, "Mirsaid");

            ValueManipulator valueManipulator = new ValueManipulator();
            IntroductionAboutUser introductionAboutUser = new IntroductionAboutUser();

            introductionAboutUser.IntroductionOfUser();
            valueManipulator.ShowMenu();

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("We have this courses");
                    break;
                   
                case 2:
                    Console.WriteLine("You want to remove the courses");
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

            Course biology = new Course
            {
                CourseName = "Biology"
            };

            Course information = new Course
            {
                CourseName = "Information"
            };
            Course english = new Course { CourseName = "English" };

            student.EnrolInCourse(information);
            student.EnrolInCourse(biology);
            student.DisplayEnrolledCourse();

            Console.WriteLine("After dropping");
            student.DropCourse(information);

            student.EnrolInCourse(english);
            student.DisplayEnrolledCourse();


            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Id : {student.StudentId}");
        }
    }
}