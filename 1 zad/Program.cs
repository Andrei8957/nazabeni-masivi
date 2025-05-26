using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedi kvadratna matrica");
            Console.Write("vuvedi broi redove = ");
            int redove = int.Parse(Console.ReadLine());
            Console.Write("vuvedi broi koloni = ");
            int koloni = int.Parse(Console.ReadLine());
            int[,] matrix = new int[redove, koloni];
            if (redove!=koloni)
            {
                Console.WriteLine("Tova ne e kvadratna matrica!");
                return;
            }
            for (int i = 0; i < redove; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < koloni; j++)

                {
                     matrix[i, j] = row[j];

                }
            }
                Console.WriteLine("po redove");
            int sum = int.MinValue;
            int mqsto1 = 0;
            int mqsto2 = 0;
            int mqsto3 = 0;
            int mqsto4 = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum1 = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (sum1 > sum)
                    {
                        sum = sum1;
                        mqsto1 = matrix[i, j];
                        mqsto3 = matrix[i, j + 1];
                        mqsto2 = matrix[i + 1, j];
                        mqsto4 = matrix[i + 1, j + 1];
                    }
                }
            }

            Console.WriteLine($"{mqsto1} {mqsto3}");
            Console.WriteLine($"{mqsto2} {mqsto4}");
           
        }
    }
}
