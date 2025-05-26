using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
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
            string[,] matrix = new string[redove, koloni];
            if (redove != koloni)
            {
                Console.WriteLine("Tova ne e kvadratna matrica!");
                return;
            }
            if (redove != 3)
            {
                Console.WriteLine("Tova ne e shah!");
                return;
            }
            for (int i = 0; i < redove; i++)
            {
                string[] row = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < koloni; j++)
                {
                    matrix[i, j] = row[j];
                    if (matrix[i, j] != "X" && matrix[i, j] != "O" && matrix[i, j] != "-")
                    {
                        Console.WriteLine("Greshno vyvedeni danni");
                        return;
                    }
                }
            }
            string rezult = "There is no winner";
            if (matrix[0, 0] != "-" && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
            {
                rezult=matrix[0, 0];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[1, 0] != "-" && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
            {
                rezult = matrix[1, 0];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[2, 0] != "-" && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
            {
                rezult = matrix[2, 0];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[0, 0] != "-" && matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
            {
                rezult = matrix[0, 0];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[0, 1] != "-" && matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
            {
                rezult = matrix[0, 1];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[0, 2] != "-" && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
            {
                rezult = matrix[0, 2];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[0, 0] != "-" && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
            {
                rezult = matrix[0, 0];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            if (matrix[0, 2] != "-" && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
            {
                rezult = matrix[0, 2];
                Console.WriteLine($"The winner is: {rezult}");
                return;
            }
            Console.WriteLine(rezult); //mogeshe da mahna rezult, no ne mi se zanimava otnovo da mu pisha stojnostite
        }
    }
}
