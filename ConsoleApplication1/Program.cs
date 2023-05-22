using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Matrix r1 = new Matrix(3,3);
            r1.ReadMatrix();
            r1.Print();
            r1.Transpose();
           // r1.Print();

        }
    }
    }
