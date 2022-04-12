using System;
using System.Collections.Generic;

namespace Array_school
{
    class Student
    {
        public int[] points { get; set; }
        public double studPoints
        {
            get
            {
            double sum = 0;
            for (var i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }
            return sum / points.Length;

            }
            
        }

    }

    class StudentClass
    {
        public Student[] students { get; set; }
        public static StudentClass generateRandomStudClass()
        {
            var rnd = new Random();
            int studentCount = rnd.Next(5, 23);
            var students = new List<Student>();

            for (var i = 0; i < studentCount; i++)
            {
                var rnd2 = new Random();
                students.Add(new Student()
                {
                    points = new int[3] { rnd2.Next(1, 6), rnd2.Next(1, 6), rnd2.Next(1, 6) }

                });
                
            }

            return new StudentClass() { students = students.ToArray() };
        }
        public static void RunApp()
        {
            var rndStudentAud = StudentClass.generateRandomStudClass();

            foreach (var item in rndStudentAud.students)
            {
                Console.WriteLine($"{item.points[0]}, {item.points[1]}, {item.points[2]}");
                Console.WriteLine(item.studPoints);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentClass.RunApp();

        }
    }
}
