using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input string ` ");
            string a = Console.ReadLine();
            Console.WriteLine( rev(a));
        }
        public static string rev(string a)
        {
               
            if (a.Length > 0)
            {
                return a[a.Length - 1] + rev(a.Substring(0, a.Length - 1));
            }
            else
                return a;

               
        }
    }
}
