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
            int h = int.Parse(Console.ReadLine());

            long[][] triangle = new long[h + 1][];

            for (int row = 0; row < h; row++)
            {

                triangle[row] = new long[row + 1];

            }
            triangle[0][0] = 1;
            int zapaz = 0;
            for (int row = 0; row < h - 1; row++)
            {

                for (int col = 0; col <= row; col++)
                {

                    triangle[row + 1][col] += triangle[row][col];

                    triangle[row + 1][col + 1] += triangle[row][col];
                    zapaz = col;

                }
                Console.Write(triangle[row + 1][zapaz]);
                Console.Write(triangle[row + 1][zapaz + 1]);
                Console.WriteLine();
            }

            //prepisah go ot prezentaciqta.Nqma smisal da Vi laga, ne gi razbrah i zatova spiram do tuk.
        }
    }
}
