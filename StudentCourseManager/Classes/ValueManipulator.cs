namespace StudentCourseManager.Classes
{
    internal class ValueManipulator
    {
        public void ShowMenu()
        {
            Console.WriteLine("_________Menu__________\n");
            Console.Write("1. Enroll Course \n2. Withdraw the course" +
                              "\n3. View enrolled course\n4. Exit \nChoice:");
        }
    }
}
