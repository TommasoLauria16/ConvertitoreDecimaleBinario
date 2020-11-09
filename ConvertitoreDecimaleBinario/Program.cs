using System;

namespace ConvertitoreDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"enter a decimal number you want convert :");
            int decimale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the base you want to convert to:");
            int b = Convert.ToInt32(Console.ReadLine());
            string numero = Convert.ToString(decimale, b).PadLeft(8,'0');
            Console.WriteLine(numero);
        }
    }
}
