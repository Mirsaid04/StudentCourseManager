namespace StudentCourseManager.Classes
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> CoursesEnrolled { get; set; }

        public Student(int studentId, string name)
        {
            Name = name;
            StudentId = studentId;
            CoursesEnrolled = new List<Course>();
        }
        public void EnrolInCourse(Course course)
        {
            CoursesEnrolled.Add(course);
        }
      
    }
}
