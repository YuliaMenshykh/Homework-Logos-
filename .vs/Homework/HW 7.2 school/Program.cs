using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7._2_school
{
    class Program
    {
        static void GeneretSchool()
        {
            var rnd = new Random();
            int AllClassCount = rnd.Next(15, 30);
            for (int i = 1; i < AllClassCount; i++)
            {
                Console.WriteLine($"{i} class____________________________________________");
                StudentAuditory studClass = new StudentAuditory();
                studClass.run();
                
            }
        }
        static void Main(string[] args)
        {
            GeneretSchool();


        }

    }
}
