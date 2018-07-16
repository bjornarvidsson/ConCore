using System;

namespace ConCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Press x to exit.");
            var key = Console.ReadKey();
            while (key.KeyChar != 'x' )
            {

                key = Console.ReadKey();
            }
            Console.WriteLine("Are you sure you want to exit? (y/n)");
            key = Console.ReadKey();
            while (key.KeyChar != 'y')
            {
                key = Console.ReadKey();
            }
// End
        }
    }
}
