using System;

namespace Dialogue
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                //dIALOG
                Console.WriteLine("We talk about Present simple tense \n In your opinion, when we use Present simple?");
                Console.WriteLine("1 When somesing regular or it is your habbits/allways happen/ permanent\t  2 When we talk about actions taking place right now\t  3 When we talk about actions who started and end in the past \t ");
                string vybir1 = Console.ReadLine();

                switch (vybir1)
                {
                    case "1":
                        Console.WriteLine("yes, it is right");
                        break;
                    case "2":
                        Console.WriteLine(" no, it is Present continuous");
                        break;
                    case "3":
                        Console.WriteLine("no, it about past");
                        break;
                }
                Console.WriteLine("\nIn your opinion,which word you could markering Present simple tense");
                Console.WriteLine("1 now/just/at the moment\t  2 sometimes/newer/usually\t  3 yesterday/last week\t");
                string vybir2 = Console.ReadLine();
                switch (vybir2)
                {
                    case "1":
                        Console.WriteLine("no, it is Present continuous");
                        break;
                    case "2":
                        Console.WriteLine("yes, it is right");
                        break;
                    case "3":
                        Console.WriteLine("no, it about past");
                        break;
                }
                Console.WriteLine("\nWhat ending of verb you will use?");
                Console.WriteLine("1 -s\t  2 -ed\t  3 -ing\t ");
                string vybir3 = Console.ReadLine();
                switch (vybir3)
                {
                    case "1":
                        Console.WriteLine("yes, it is right");
                        break;
                    case "2":
                        Console.WriteLine("Thet`s not right");
                        break;
                    case "3":
                        Console.WriteLine("Thet`s not right");
                        break;
                }
            

        }
    }
}
