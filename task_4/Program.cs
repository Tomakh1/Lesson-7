using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number : ");      ////bazmapatkman axyusak
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            mult(num,a);
        }

        public static void mult(int num,int a)
        {
            if (a <= 10)
            {
                int z = a * num;
                Console.WriteLine(a + " * " + num + " = " + z);
                a++;
                
                mult(num, a);
            }
        }
    }
}
