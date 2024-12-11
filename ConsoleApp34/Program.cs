using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число int:");
            int numberInt32 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число X:");
            int numberX = int.Parse(Console.ReadLine());

            int result = CountBitsToChange(numberInt32, numberX);
            Console.WriteLine($"Количество бит, которые нужно изменить: {result}");
        }

        static int CountBitsToChange(int numberInt32, int numberX)
        {
            int xorResult = numberInt32 ^ numberX;
            int count = 0;

            while (xorResult != 0)
            {
               count += xorResult & 1; 
               xorResult >>= 1;       
            }

            //for (; xorResult != 0; xorResult >>= 1)
            //{
            //    count += xorResult & 1; 
            //}


            return count;
        }
    }
}
