using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7._2_school
{
    class Program
    {
        class AllSchoolPoint : StudentAuditory
        {
            StudentAuditory studClass = new StudentAuditory();

            

            public static AllSchoolPoint generateAllSchoolPointy()
            {
                var rnd = new Random();
                int AllClassCount = rnd.Next(15, 30);
                var classes  = new List<StudentAuditory>();

                for (var i = 0; i < AllClassCount; i++)
                {
                    students.Add(new Student()
                    {
                        points = new int[3] { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) }
                    });
                }

                return new StudentAuditory() { students = students.ToArray() };
            }

        }
        static void Main(string[] args)
        {
            StudentAuditory.run();

        }
    }
}
