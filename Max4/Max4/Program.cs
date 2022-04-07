using System;

namespace Max4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("ivan", 3.5, 3);
            Student_with_english student_With_English = new Student_with_english("ivan", 3.5, 3, true);
            Console.WriteLine(student.get_Q());
            Console.WriteLine(student_With_English.get_Q());
        }
    }
}
