using System;

namespace logicCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            A = 1; B = 20; C = 40;
            int Mayor = 0;
            int Menor = 0;

            if (A > B)
            {
                if (C > A)
                {
                    Mayor = C;
                    Menor = B;
                }
                else if (C > B)
                {
                    Mayor = A;
                    Menor = B;
                }
                else
                {
                    Mayor = A;
                    Menor = C;
                }

            }
            else if (A > C)
            {
                Mayor = B;
                Menor = C;
            }
            else
            {
                Mayor = B;
                Menor = A;
            }

            Console.WriteLine($"MAYOR:{Mayor}, menor:{Menor}");
        }
    }
}
