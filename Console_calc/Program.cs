using System;
using System.Collections.Generic;
namespace Console_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool e = true;
            while(e == true)
            { Console.WriteLine("Hello, Select any one option");
             Console.WriteLine("1. Addition");
             Console.WriteLine("2. Subtraction");
             Console.WriteLine("3. Multiplication");
             Console.WriteLine("4. Get factorial of number");
             int select = Convert.ToInt32(Console.ReadLine());
            
          
             if(select == 1)
             {
                    Console.WriteLine("Enter First Number");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Program q = new Program();
                    Console.WriteLine(q.Add( x, y));
               
                //int sum = x + y;
                //Console.WriteLine("sum=" + sum);
                    

             }
             if (select == 2)
             {
                Console.WriteLine("Enter First Number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second Number");
                int y = Convert.ToInt32(Console.ReadLine());
                //Program s = new Program();
                Console.WriteLine(Sub(x, y));
                //if (x > y)
                //{
                    
                //    int sub = x - y;
                //    Console.WriteLine("subtraction output= " + sub);
                //}
                //else
                //{
                //    Console.WriteLine("output will be 0 or negative");
                //}
                    
             }
                if (select == 3)
                {
                    Console.WriteLine("Enter First Number");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second Number");
                    int y = Convert.ToInt32(Console.ReadLine());
                    //Program d = new Program();
                    Console.WriteLine(Mul(x, y));
                    //int mul = x * y;
                    //Console.WriteLine("Multiplication output= " + mul);
                    
                }
                if (select == 4)
                {
                    Console.WriteLine("Enter the Number");
                    int x = Convert.ToInt32(Console.ReadLine());
                    //Program g = new Program();
                    Console.WriteLine(Fact(x));
                }
            }


        }
        public int Add(int x, int y)
        {
            //Console.WriteLine("Enter First Number");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second Number");
            //y = Convert.ToInt32(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine("sum = " + sum);
            return (sum);
        }
        public static int Sub(int x, int y)
        {
            int subtract = x - y;
            Console.WriteLine("Substraction output = " + subtract);
            return (subtract);
        }
        public static int Mul(int x, int y)
        {
            int multiply = x * y;
            Console.WriteLine("Multiplication output = " + multiply);
            return (multiply);
        }
        
        public static int Fact(int x)
        {
            int f = 1;
            for(int u=1; u <= x; u++)
            {
                f = f * u;

            }
            Console.WriteLine("Requried factorial is " + f);
            return (f);
        }
        
        
        //Console.WriteLine("do you want to continue --> yes or no");
        //bool i = yes;
        //   {
        //  return; 
        //     }
    }
       // public static int Add(int x, int y);
        //{
        //int sum = x + y;
        //}

}

