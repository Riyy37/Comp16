using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    /// <summary>
    /// Задание 3. Вывести на экран прямоугольник вида □, 
    /// обрамленный символами (например, 16 на 16) и пустой внутри.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 16;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                        Console.Write("#"); 
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
