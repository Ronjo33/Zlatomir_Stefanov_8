using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на учениците:");
            int n = int.Parse(Console.ReadLine());

            int[] grades = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведете успеха на ученик {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            double average = grades.Average();
            Console.WriteLine($"Средният успех на групата е: {average:F2}");
            //За намиране на учениците със среден успех или най-близък до средния успех
            int[] closestGrades = grades
                .Where(grade => Math.Abs(grade - average) <= 0.5)
                .ToArray();

            Console.WriteLine("Учениците със среден успех или най-близък до средния успех са с номера:");
            foreach (int grade in closestGrades)
            {
                //използвam Array.IndexOf за намиране на индекса на успеха в масива grades
                Console.WriteLine($"Номер:{ Array.IndexOf(grades, grade) + 1}");
            }
        }
    }
}
