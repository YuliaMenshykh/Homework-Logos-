using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace _12._1__HW_write_data_in_file
{
    class Program
    {
       
        static void Main(string[] args)
        {

            using (var myFile = File.Open("myFileForWriting.txt", FileMode.OpenOrCreate))
            {
                myFile.Write(Encoding.UTF8.GetBytes("I`m writing something"));
            }
            
        }
    }
}
