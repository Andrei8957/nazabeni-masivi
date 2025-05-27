using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko shiida iskash Ivancho? - ");
            int n = int.Parse(Console.ReadLine());
            int[][,] sh = new int[n][,];
            int Min = int.MaxValue;
            int Max = int.MinValue;
            int Sum = 0;
            double Avg = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Kolko reda da e golqm sledvashiqt shiid Ivancho? - ");
                int red = int.Parse(Console.ReadLine());
                Console.Write("Kolko koloni da e golqm sledvashiqt shiid Ivancho? - ");
                int kol = int.Parse(Console.ReadLine());
                if (red != kol)
                {
                    Console.WriteLine("Trqbva da e kvadratna matrica, dokolkoto razbrah, Ivancho!");
                    return;
                }
                int[,] matrix = new int[red, kol];
                int sum = 0;
                int count = 0;

                for (int j = 0; j < red; j++)
                {
                    Console.WriteLine($"Vuvedi red {j + 1}:");
                    int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    for (int o = 0; o < kol; o++)
                    {
                        matrix[j, o] = row[o];
                        if (matrix[j, o] < Min)
                        {
                            Min = matrix[j, o];
                        }
                        if (matrix[j, o] > Max)
                        {
                            Max = matrix[j, o];
                        }
                        sum += matrix[j, o];
                        count++;
                    }
                }

                double avg = (double)sum / count;
                Avg += avg;
                Sum += sum;
                sh[i] = matrix;

                Console.WriteLine($" minimalnoto chislo ot shiida, Ivancho, e {Min}");
                Console.WriteLine($" maksimalnoto chislo ot shiida, Ivancho, e {Max}");
                Console.WriteLine($"sredno aretmitichnoto na tozi shiid, Ivancho, e {avg:F2}");
            }


            double globalAvg = Avg / n;
            Console.WriteLine($"sredno aretmitichnoto ot vsichki sheedove, Ivancho, e {globalAvg:F2}");
            Console.Write("Sreshaniqta na po-golemi chisla ot sredno aretmitichnoto ot vsichki sheedove, Ivancho, sa ");
            int count1 = 0;
            for (int i = 0; i < n; i++)
            {

                int[,] matrix = sh[i];
                int red = matrix.GetLength(0);
                int kol = matrix.GetLength(1);

                for (int r = 0; r < red; r++)
                {
                    for (int c = 0; c < kol; c++)
                    {
                        if (matrix[r, c] > globalAvg)
                        {
                            count1++;
                        }

                    }
                }
            }
            Console.Write($"Sreshaniqta na po-golemi chisla ot sredno aretmitichnoto ot vsichki sheedove, Ivancho, sa {count1}");
        }
    }
}
