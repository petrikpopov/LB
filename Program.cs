using System;

namespace _01._02._2023LB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//1
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("It's easy to win forgiveness for being wrong;\n being right is what gets you into real trouble.\nBjarne Stroustrup\n");

            //2
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int R = a + b + c + d + e;
            int M = a * b * c * d * e;
            Console.WriteLine("Result = " + R);
            Console.WriteLine("Result multiply = " + M);
            if (a > b && a > c && a > d && a > c && a > e)
            {
                Console.WriteLine("A Win");

            }
            else if (a < b && a < c && a < d && a < c && a < e)
            {
                Console.WriteLine("A Lose");
            }
            if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("B Win");
            }
            else if (b < a && b < c && b < d && b < e)
            {
                Console.WriteLine("B Lose");
            }
            if (c > a && a > b && c > d && c > e)
            {
                Console.WriteLine("C Win");
            }
            else if (c < a && c < b && c < d && c < e)
            {
                Console.WriteLine("C Lose");
            }
            if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("D Win");
            }
            else if (d < a && d < b && d < c && b < e)
            {
                Console.WriteLine("D Lose");
            }
            if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine("E Win");
            }
            else if (e < a && e < b && e < c && e < d)
            {
                Console.WriteLine("E Lose");
            }*/

            //3
            /*Console.WriteLine("\nTask 3 \n");
            string buf = Console.ReadLine();
            Console.Write("Reverse: ");
            for (int i = buf.Length - 1; i >= 0; i--)
                Console.Write($"{buf[i]}");
            Console.WriteLine("\n");*/

            string A = Console.ReadLine();
            for (int i = A.Length-1; i>=0; i--)// идем назад
            {
                
                Console.Write($"{A[i]}");
            }
            
            /*//6
            Console.WriteLine("Введите длину линии");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("1) Горизонтальная, 2)Вертикальная");
            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                for (int i = 0; i < S; i++)
                {
                    Console.Write("+");
                }
            }
            else if (N==2)
            {
                for (int i = 0; i<S; i++)
                {
                    Console.WriteLine("+");
                }
            }*/
        }



    }
}

