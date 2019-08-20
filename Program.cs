using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                foreach(var name in args)
                {
                    Console.WriteLine("Hello " + name + "!");
                }               
            }
            else 
                System.Console.WriteLine("No name specified.");
        }
    }
}
