//A
//1.

using System;

namespace Program
{
    class Program1
    {
        static void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }
        static int GetRandom()
        {
            Random random = new Random();
            int rand = random.Next(0, 101);
            return rand;

        }
        static int GetMultiplay(int x) 
        {

            x *= 3;
            return x;
        }
        static int  GetPlus(int x,int y)
        {
            return x + y;
        }
        static int GetMinus(int x, int y)
        {
            return x-y;
        }
        static string GetName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            return name;
            
        }
        static int GetDivision(int s, int l)
        {
            return s / l;
        }
        static  string GetJog()
        {
            Console.WriteLine("whats your job?");
           
            return Console.ReadLine();
        }

       

        
        static void Main(string[] args)
        {
            PrintHello();
          Console.WriteLine(GetRandom());
            Console.WriteLine(GetMultiplay(3));
            Console.WriteLine(GetPlus(3,4));
            Console.WriteLine(GetMinus(3, GetRandom()));
            Console.WriteLine(GetName());
            Console.WriteLine(GetDivision(10, 2));
           Console.WriteLine(GetJog());


        }

        


        
    }
}
       

//2.

//B - Function Methods
//1.
//Random random1 = new Random();
//int rand1 = random.Next(1, 9);
//Console.WriteLine(rand1);
