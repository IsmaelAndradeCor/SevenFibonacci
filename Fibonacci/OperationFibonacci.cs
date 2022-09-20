using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class OperationFibonacci
    {
        public static void presentacion()
        {
            Console.WriteLine("Hola! Vamos a mostrar cual es el enesimo numero de la secuencia Fibonacci");
            int res = operation(7);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        internal static int operation(int num)
        {
            int x = 1;
            int y = 1;
            int z = 0;

            for (int i = 1; i < 7; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            return x;
        }

    }
}
