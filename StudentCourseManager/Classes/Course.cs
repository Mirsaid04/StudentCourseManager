using System.Security.Cryptography.X509Certificates;

namespace StudentCourseManager.Classes
{
    internal class Course
    {
        public void enrollTheCourse()
        {
            List<string> courses = new List<string>
        {
            "Mathematics",
            "Science",
            "History",
            "English",
            "Programming",
        };

            Console.WriteLine("Choose your courses by entering their index:");

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {courses[i]}");
            }

            Console.Write("Enter the index of the courses you want (comma-separated): ");
            string input = Console.ReadLine()!;

            List<string> selectedCourses = new List<string>();

            foreach (string index in input.Split(','))
            {
                if (int.TryParse(index, out int courseIndex) && courseIndex > 0 && courseIndex <= courses.Count)
                {
                    selectedCourses.Add(courses[courseIndex - 1]);
                }
            }

            Console.WriteLine("You have selected the following courses:");
            foreach (string course in selectedCourses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
