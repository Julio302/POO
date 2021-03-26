using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Perro
    {
        public virtual string ladrar()
        {
            return "Perro ladrando";
        }
    }

    //hereda de perro
    public class Chihuahua : Perro
    {
        public override string ladrar()
        {
            return "Chihuahua ladrando";
        }
    }

    public class Bulldog : Perro
    {
        public override string ladrar()
        {
            return "Bulldog ladrando";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua _chi1 = new Chihuahua();
            Chihuahua _chi2 = new Chihuahua();
            Bulldog _bull1 = new Bulldog();
            Bulldog _bull2 = new Bulldog();

            Perro[] _perrera = { _chi1, _chi2, _bull1, _bull2 };
            foreach (Perro item in _perrera)
            {
                Console.WriteLine(item.ladrar());
            }
            Console.ReadKey();
        }
    }
}
