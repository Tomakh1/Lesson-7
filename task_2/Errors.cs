using System;

namespace task_2
{
    class Errors
    {
        static void Main()
        {
            //task er = new task();
            var a = Console.Read();
            //task err = new task();
           task err = (task)a;
            switch (err)
            {
                case task.CS0016:
                    Console.Write((int)task.CS0016);
                    Console.WriteLine("Could not write to output file ‘{0}’ — ‘{1}’");
                    break;
                case task.CS0012:
                    Console.Write((int)task.CS0012);
                    Console.WriteLine("The type ‘{0}’ is defined in an assembly that is not referenced. You must add a reference to assembly ‘{1}’.");
                    break;

                default:
                    break;

            }
            
        }
    }

    public enum task
    {
        CS0016,
        CS0012,
        CS0019,
        CS0034,
        CS0061,
        CS0071,
        CS0082,
        CS0112,
        CS0116,
        CS0140,


    }
}
