using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranposteHerencia
{
    public class Program
    {
        public class Transportes
        {
            public class Aereos:Transportes
            {
                public string TipoCombustible { get; set; }

                private int _id;
                private string _TipoCombustible;
                private string _Cmax;
                private string _VelMax;
                private string _VelMin;
                private string _Modelo;
                private string _NombreCapitan;

                public Aereos(){}
                    public Aereos(int id, string Cmax, string VelocidadMax, string VelocidadMin, 
                                    string Modelo, string NombreCapitan, string tipoCombustible){
                        this._id = id;
                        this._TipoCombustible = tipoCombustible;
                        this._Cmax = Cmax;
                        this._VelMax = VelocidadMax;
                        this._VelMin = VelocidadMin;
                        this._Modelo = Modelo;
                        this._NombreCapitan = NombreCapitan;
                    }

                    public virtual string Datos()
                    {
                        return _id + " " +
                            _Cmax + " " +
                    _VelMax + " " + _VelMin + " " + _Modelo + " " +
                    _NombreCapitan + " + " + _TipoCombustible;
                    }
            }
            public class Avioneta : Aereos
            {
                public Avioneta(int id, string CMax, string VelMax, string VelMin, string Modelo, string NombreCapitan, string Tipogas) : base( id, CMax, VelMax, VelMin, Modelo,  NombreCapitan, Tipogas) { }
                public override string Datos()
                {
                    return base.Datos();
                }
            }
            public class Elicoptero : Aereos
            {
                public Elicoptero(int id, string CMax, string VelMax, string VelMin, string Modelo, string NombreCapitan, string Tipogas) : base(id, CMax, VelMax, VelMin, Modelo, NombreCapitan, Tipogas) { }
                public override string Datos()
                {
                    return base.Datos();
                }
            }


            public class Terrestres : Transportes
            {
                private int _id;
                private string _TipoCombustible;
                private string _Cmax;
                private string _VelMax;
                private string _VelMin;
                private string _Modelo;
                private string _NombreConductor;
                private int _CantidadLlantas;

                public Terrestres() { }
                public Terrestres(int id, string Cmax, string VelocidadMax, string VelocidadMin,
                                    string Modelo, string NombreConductor, int CantidadLlantas, string tipoCombustible)
                {
                    this._id = id;
                    this._Cmax = Cmax;
                    this._VelMax = VelocidadMax;
                    this._VelMin = VelocidadMin;
                    this._Modelo = Modelo;
                    this._NombreConductor = NombreConductor;
                    this._CantidadLlantas = CantidadLlantas;
                    this._TipoCombustible = tipoCombustible;
                }
                public virtual string Datos()
                {
                    return _id + " " + _Cmax + " "
                          + _VelMax + " " + _VelMin + " " + _Modelo + " " + _NombreConductor + " " + _CantidadLlantas
                          + " " + _TipoCombustible;
                }
            }

            public class Carro : Terrestres
            {
                public Carro(int id, string Cmax, string VelocidadMax, string VelocidadMin,
                                    string Modelo, string NombreConductor, int CantidadLlantas, string tipoCombustible)
                    : base(id,  Cmax,  VelocidadMax,  VelocidadMin,
                                    Modelo, NombreConductor, CantidadLlantas, tipoCombustible) { }
                public override string Datos()
                {
                    return base.Datos();
                }
            }

            public class Moto : Terrestres
            {
                public Moto(int id, string Cmax, string VelocidadMax, string VelocidadMin,
                                    string Modelo, string NombreConductor, int CantidadLlantas, string tipoCombustible)
                    : base(id, Cmax, VelocidadMax, VelocidadMin,
                                    Modelo, NombreConductor, CantidadLlantas, tipoCombustible) { }
                public override string Datos()
                {
                    return base.Datos();
                }
            }


            public class Maritimos : Terrestres
            {
                private int _id;
                private string _TipoCombustible;
                private string _Cmax;
                private string _VelMax;
                private string _VelMin;
                private string _Modelo;
                private string _NombreCapitan;
                private string _Ataque;

                public Maritimos() { }
                public Maritimos(int id, string Cmax, string VelocidadMax, string VelocidadMin,
                                    string Modelo, string NombreCapitan, string tipoCombustible, string Ataque)
                {
                    this._id = id;
                    this._Cmax = Cmax;
                    this._VelMax = VelocidadMax;
                    this._VelMin = VelocidadMin;
                    this._Modelo = Modelo;
                    this._NombreCapitan = NombreCapitan;
                    this._TipoCombustible = tipoCombustible;
                    this._Ataque = Ataque;
                }
                public virtual string Datos()
                {
                    return _id + " " + _Cmax + " " + _VelMax + " " + _VelMin + " " + _Modelo + " " + _NombreCapitan + " " + _TipoCombustible + " " +  _Ataque; 
                }
            }


            public class Submarino : Maritimos
            {
                public Submarino(int id, string Cmax, string VelocidadMax, string VelocidadMin,
                                    string Modelo, string NombreCapitan, string tipoCombustible, string Ataque)
                    : base( id,  Cmax,  VelocidadMax,  VelocidadMin,
                                    Modelo, NombreCapitan,  tipoCombustible,  Ataque) { }
                public override string Datos()
                {
                    return base.Datos();
                }
            }
            public class Crucero : Maritimos
            {
                public Crucero(int id, string Cmax, string VelocidadMax, string VelocidadMin,
                                    string Modelo, string NombreCapitan, string tipoCombustible, string Ataque)
                    : base(id, Cmax, VelocidadMax, VelocidadMin,
                                    Modelo, NombreCapitan, tipoCombustible, Ataque) { }
                public override string Datos()
                {
                    return base.Datos();
                }
            }

        }

            
        
        static void Main(string[] args)
        {
            Transportes.Aereos A = new Transportes.Avioneta(1, "120 personas", "1203km", "5km", "serie x", "piloto juan", "usa dicel");
            Transportes.Aereos B = new Transportes.Elicoptero(2, "320 personas", "5203km", "5km", "serie precidencial", "piloto raul", "usa gasolina");
            Console.WriteLine("Transportes Aereos");
            Console.WriteLine("Transporte {0:f2}", A.Datos());
            Console.WriteLine("Transporte {0:f2}", B.Datos());

            Transportes.Terrestres C = new Transportes.Carro(3, "4 personas", "1203km", "5km", "serie BMW", "Conductor juan", 4, "usa dicel");
            Transportes.Terrestres D = new Transportes.Carro(4, "2 personas", "1203km", "5km", "serie Italika", "Conductor Manuel", 2, "usa gasolina");
            Console.WriteLine("Transportes Terrestres");
            Console.WriteLine("Transporte {0:f2}", C.Datos());
            Console.WriteLine("Transporte {0:f2}", D.Datos());

            Transportes.Maritimos E = new Transportes.Submarino(5, "30 personas", "400km", "2km", "z-300", "Capitan joel", "usa dicel", "Puede atacar");
            Transportes.Maritimos F = new Transportes.Crucero(6, "3000 personas", "10km", "1km", "experience -x", "Capitan prices", "usa dicel", "No puede atacar");
            Console.WriteLine("Transportes Maritimos");
            Console.WriteLine("Transporte {0:f2}", E.Datos());
            Console.WriteLine("Transporte {0:f2}", F.Datos());

            Console.ReadKey();
        }
    }
}
