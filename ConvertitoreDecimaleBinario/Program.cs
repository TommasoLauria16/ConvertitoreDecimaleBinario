using System;

namespace ConvertitoreDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base you want to convert to");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter a decimal number you want to convert to base{b}");
            int decimale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(decimale,2));
        }
    }
}
