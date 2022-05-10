using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7._2_school
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
}
