﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace HW_15._3
{
    class Program
    {
        

        static async void LoadingLine()
        {
           
            int loading = 10;

            Console.Write("[");

            for(int i = 0; i < loading; i++)
            {
                Console.Write("_Loading_");
                Thread.Sleep(500);

            }
            for (int i = 0; i < 10- loading ; i++)
            {
                Console.Write(" ");
            }
            Console.Write("] \n");


            await Task.Run(() => { confuthe(); });

        }

        static void confuthe()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I`m trying confuse you");
                Thread.Sleep(500);
            }
        }



        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(LoadingLine));
            thread.Start();

            


        }
    }
}
