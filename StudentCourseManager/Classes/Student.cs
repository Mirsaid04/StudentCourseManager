namespace StudentCourseManager.Classes
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public List<Course> CoursesEnrolled { get; set; }

        public Student(string studentId, string name)
        {
            Name = name;
            string student = studentId;
            CoursesEnrolled = new List<Course>();
        }

        public void EnrolInCourse(Course course)
        {
            CoursesEnrolled.Add(course);
        }
        public void DropCourse(Course course)
        {
            CoursesEnrolled.Remove(course);
        }
        public void DisplayEnrolledCourse()
        {
            Console.WriteLine("Here are enrolled courses: ");

            foreach (var course in CoursesEnrolled)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
}
