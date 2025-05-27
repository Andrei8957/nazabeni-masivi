using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko reda da e golqm - ");
            int h = int.Parse(Console.ReadLine());
            int[][] pascal = new int[h][];

            for (int i = 0; i < h; i++)
            {
                int[] currentRow = new int[i + 1];
                currentRow[0] = 1;
                currentRow[i] = 1;

                for (int j = 1; j < i; j++)
                {
                    currentRow[j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }

                pascal[i] = currentRow;
            }

            Print(pascal);
        }

        private static void Print(int[][] arr)
        {
            int h = arr.Length;
            for (int row = 0; row < h; row++)
            {
                Console.Write(new string(' ', (h - row - 1) * 2));

                for (int col = 0; col < arr[row].Length; col++)
                {
                    Console.Write(arr[row][col] + "   ");
                }

                Console.WriteLine();
            }
        }
    }
}




