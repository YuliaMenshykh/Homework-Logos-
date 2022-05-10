using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__7._1_student_assessment
{
    class Program
    {
        class StudClass
        {
            class Student
            {
                public int[] points { get; set; }
                public double avgPoint
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

            class StudentAuditory
            {
                public Student[] students { get; set; }
                public static StudentAuditory generateRandomStudAuditory()
                {
                    var rnd = new Random();
                    int studentCount = rnd.Next(15, 30);
                    var students = new List<Student>();

                    for (var i = 0; i < studentCount; i++)
                    {
                        students.Add(new Student()
                        {
                            points = new int[3] { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) }
                        });
                    }

                    return new StudentAuditory() { students = students.ToArray() };
                }
            }
            public static void run()
            {
                var rndStudentAud = StudentAuditory.generateRandomStudAuditory();

                foreach (var item in rndStudentAud.students)
                {
                    Console.WriteLine($"{item.points[0]}, {item.points[1]}, {item.points[2]}");
                    Console.WriteLine(item.avgPoint);
                    Console.WriteLine();
                }

            }
        }


        static void Main(string[] args)
        {
            StudClass.run();
        }
    }
}
