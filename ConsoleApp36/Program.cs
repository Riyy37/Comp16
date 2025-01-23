using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    /// <summary>
    /// Задание 2. Вывести на экран 4 горизонтальные строки, каждая из которых состоит из 7 символов, 
    /// отделенных друг от друга пустыми строками
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<4; i++)
            {
               for (int j= 0; j< 7; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                Console.WriteLine();
            }   
            Console.ReadKey();
        }
    }
}
