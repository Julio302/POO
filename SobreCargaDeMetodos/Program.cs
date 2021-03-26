using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaDeMetodos
{
    class Program
    {
        public int Sumar(int x, int y)
        {
            int resp = x + y;
            return resp;
        }
        public String Sumar(string s1, string s2)
        {
            string resp = s1 + s2;
            return resp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("La suma de 5+10 es:" + p.Sumar(5, 10));
            Console.WriteLine("La concatenacion de de string " + p.Sumar("Juan", " Carlos"));
            Console.ReadKey();
        }
    }
}
