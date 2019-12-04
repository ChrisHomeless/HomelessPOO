using System;
using System.Collections.Generic;

namespace alumno
{
    class Alumno
    {
        protected string Name;
        public Alumno(string a)
        {
            Name = a;
        }
        public virtual void Presente()
        {
            Console.WriteLine("Hola, que tal? soy {0}", Name);
        }
        public virtual void Accion()
        {
            Console.WriteLine("{0}, Posar {0}", Name);
        }
    }
    class Licenciatura:Alumno
    {
        private string Lic;
        public Licenciatura(string no,string L):base(no)
        {
            this.Lc = L;
        }
        public override void Accion()
        {
            Console.WriteLine("FOR MY FUTURE! {1}", Name, Lic);
        }
    }
    class Posgrado:Alumno
    {
        private string Pgr;
        public Posgrado(string no,string P):base(no)
        {
            this.Pgr=P;
        }
        public override void Accion()
        {
            Console.WriteLine("Estoy en Posgrado y I CAN DO IT! {1}", Name, Pgr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Tomas=new Alumno("x");
            Licenciatura flea=new Licenciatura("Willy","Residencia y Servicio social.");
            Posgrado Poss=new Posgrado("Dross","Investigacion.");

            List <Alumno> grupo = new List <Alumno>();
            grupo.Add(flea);
            grupo.Add(Poss);

            foreach(Alumno m in grupo)
            {
                m.Presente();
                m.Accion();
                Console.WriteLine(" ");
            }
        }
    }
}
