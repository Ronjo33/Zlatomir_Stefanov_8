using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете целите числа, разделени с интервал:");
            string input = Console.ReadLine();
            string[] num = input.Split(' ');
            // Обръщане на масива
            Array.Reverse(num);
            // Печат на елементите с разделител запетая
            Console.WriteLine(string.Join(", ", num));

        }
    }
}
