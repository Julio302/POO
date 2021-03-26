using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Factorial
            //Factorial
            //int fac = 1, x, num;
            //x = 1;
            //Console.Write("Ingrese un numero entero: ");
            //num = int.Parse(Console.ReadLine());
            //while (x <= num)
            //{
            //    fac = fac * x;
            //    x = x + 1;
            //    Console.WriteLine("La factorial es: " + fac);
            //}
            

            //factorial recursivo
            int num;
            int fac = 1;
            Console.WriteLine("Ingresa un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su factorial es: {0}", fact(num));
            
            Console.ReadKey();

        }

        private static long fact(int num)
        {
            if (num == 1)
                return 1;
            //return num * fact(num - 1); //si no es uno se genera la recursividad
            return num * fact(num - 1);
        }
    }
}
