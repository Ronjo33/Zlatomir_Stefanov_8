using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Въведете броя на учениците:");
            int n = int.Parse(Console.ReadLine());

            //Въвежда оценката на ученика.
            int[] grades = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведете успеха на ученик {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            //Ако това е вярно да продалжава надоло.
            while (true)
            {
                Console.Write("Искате ли да промените оценки? (Y/N): ");

                string yesorno = Console.ReadLine();

                if (yesorno.ToUpper() == "Y")
                {
                    Console.Write("Въведете номера на ученика, на който искате да промените оценката: ");
                    int studentNum = int.Parse(Console.ReadLine());

                    if (studentNum >= 1 && studentNum <= n)
                    {
                        Console.Write("Въведете новата оценка: ");
                        int newGrade = int.Parse(Console.ReadLine());

                        int oldGrade = grades[studentNum - 1];
                        grades[studentNum - 1] = newGrade;

                        Console.WriteLine($"Нова оценка: {newGrade}");
                        Console.WriteLine($"Стара оценка: {oldGrade}");
                    }
                    else
                    {
                        Console.WriteLine("Невалиден номер на ученик.");
                    }
                }
                //Това спира задачата.
                else if (yesorno.ToUpper() == "N")
                {
                    break;
                }
                //Това се  случва когато дадеш нещо различно от Y' или 'N.
                else
                {
                    Console.WriteLine("Невалиден отговор. Моля, въведете 'Y' или 'N'.");
                }
            }
        }  
    }
}
