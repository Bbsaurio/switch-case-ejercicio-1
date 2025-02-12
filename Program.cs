using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("suma");
            System.Console.WriteLine("resta");
            System.Console.WriteLine("multiplicacion");
            System.Console.WriteLine("divicion");
            System.Console.WriteLine("elige opcion");
            int OP = int.Parse(Console.ReadLine());
            System.Console.WriteLine("ingresa el primer valor");
            int N1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("ingresa el segundo numero");
            int N2=int.Parse(Console.ReadLine());
            switch (OP)
            {
                case 1:
                    System.Console.WriteLine("suma");
                    int S = N1 + N2;
                    System.Console.WriteLine("el resultado es:" + S);
                    break;
                case 2:
                    System.Console.WriteLine("resta");
                    int R = N1 - N2;
                    System.Console.WriteLine("el resultado es:" + R);
                    break;
                case 3:
                    System.Console.WriteLine("multiplicacion");
                    int M = N1 * N2;
                    System.Console.WriteLine("el resultado es:" + M);
                    break;
                case 4:
                    System.Console.WriteLine("divicion");
                    int D = N1 / N2;
                    System.Console.WriteLine("el resultado es:" + D);
                    break;
                default:
                    System.Console.WriteLine("operacion no valida");
                break;
            }
            Console.ReadKey();

        }
    }
}
