using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    /// <summary>
    /// Задание 1. Напечатать числа в виде следующей таблицы:
    /// </summary>
    internal class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица (а):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Таблица (б):");
            int num = 41;
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 10; j++) 
                {
                    Console.Write(num + "\t");
                    num++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Таблица (в):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j<=i; j++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Таблица (г):");
            for (int i = 0; i < 5; i++)
            {
                for (int j =0; j < 5 - i; j++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
