using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student1 = new Student("Student 1", 100, 4);
            for (int i = 0; i < 5; i++)
            {
                student1.Learn();
            }

            student1.Effort(-1);
            Console.WriteLine(student1.PredictGrade());
        }
    }
}
