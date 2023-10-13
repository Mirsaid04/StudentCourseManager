namespace StudentCourseManager.Classes
{
    internal partial class IntroductionAboutUser
    {
        public void IntroductionOfUser()
        {
            Console.WriteLine("\nWelcome to our Student Course Enrollment system!\n");
            Console.Write("Please, Enter your name!\nName: ");
            string userName = Console.ReadLine()!;
            Console.WriteLine("Thank you for using our application");
        }
    }
}
