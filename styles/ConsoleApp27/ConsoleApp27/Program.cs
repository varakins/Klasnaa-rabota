using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class Program
    {
        static void Main(string[] args)
        {

            int number = 15;

            Console.WriteLine($"Куб числа {number}: {Cube(number)}");
            Console.WriteLine($"Квадрат числа {number}: {Square(number)}");
            Console.WriteLine($"Сумма чисел {number} и 3: {Sum(number, 3)}");

            Console.ReadKey();
        }

        
        static int Cube(int x)
        {
            return x * x * x;
        }

    
        static int Square(int x)
        {
            return x * x;
        }

      
        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
