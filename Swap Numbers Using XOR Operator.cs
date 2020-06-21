using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping");
            Console.WriteLine("x = {0} \t b = {1}", x, y);
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;         
            Console.WriteLine("After Swapping");
            Console.WriteLine("x = {0} \t b = {1}", x, y);
            Console.ReadLine();
        }
    }
}
