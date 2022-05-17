using System;

namespace Mang2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap so dong");
            int Rows =int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so cot");
            int Columns = int.Parse(Console.ReadLine());

            int[,] Array = new int[Rows, Columns];

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    Console.Write("Moi ban nhap pha tu thu [{0},{1}]", i, j);
                    Array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int Sum = 0;

            Console.WriteLine("\nMang vua nhap la: ");
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    Console.Write(Array[i, j] + " ");
                    Sum = Sum + Array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tong cac gia tri cua mang la: " + Sum);
        }
    }
}
