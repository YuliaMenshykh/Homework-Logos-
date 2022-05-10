using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7._2_school
{
    class StudentAuditory : Student
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
}
