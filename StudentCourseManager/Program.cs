using StudentCourseManager.Classes;

namespace StudentCourseManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1118, "Mirsaid");

            Course biology = new Course
            {
                CourseName = "Biology"
            };

            Course information = new Course
            {
                CourseName = "Information"
            };
            Course english = new Course { CourseName = "English" };


            /* student.Add(english);*/

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