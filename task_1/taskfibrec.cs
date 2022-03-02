using System;

namespace task_1
{
    class taskfibrec
    {

        static void Main()
        {
            Console.Write("num= ");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 1, next;
            Console.Write(num1 + " " + num2 + " ");
            next = num1 + num2;
            Fib(num, num1, num2, next);
        }
    

        public static void Fib(int num,int num1,int num2,int next)
        {          
            
                if (next <= num)
                {
                    Console.Write(next + " ");
                    num1 = num2;
                    num2 = next;
                    next = num1 + num2;

                    Fib(num, num1, num2, next);
                }
            
           
        }
    }

}
