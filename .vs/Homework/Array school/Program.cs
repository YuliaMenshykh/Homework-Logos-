using System;

namespace Array_school
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomRating = new Random();
            int Rating = randomRating.Next (1, 13);




            int minVaiue = 6;
            int maxValue = 23;
            Random randomPeople = new Random();
            

            int[] people = { };
            Random randNum = new Random();
            foreach (int value in people)
            {
                randNum.Next(minVaiue, maxValue);
            }




            int[,] StudentPoint = new int [people, Rating];

            int medPoint;
            for (int i = 0; i < ; i++)
            {

            }

        }
    }
}
