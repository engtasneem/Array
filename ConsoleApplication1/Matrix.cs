using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Matrix
    {
        private int[,] arr;
        private int n;
        private int m;
        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            arr = new int[n, m];
        }
        public void ReadMatrix()
        {
            Console.WriteLine("Enter the value");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Transpose()
        {
            int[,] arr2 = new int[m, n];
            Console.WriteLine("Original of Array:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[j, i] = arr[i, j];
                }
            }
            Console.WriteLine("Transpose of Array:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j]);
                }
                Console.WriteLine();
            }

        }
        public void Print()
        {
            Console.WriteLine("print the arr matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(arr[i, j]);

                }






            }
        }
    }
}