using System;
using System.Collections.Generic;

namespace parametros
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public string ciudad;
        public string pais;
        public Persona()
        {
            nombre = "chris";
            apellido = "martinez";
            ciudad = "tijuana";
            pais = "mexico";
        }
    }
    class Anonimo
    {
        public static void anonim( Persona p)
        {
            p.nombre = "xxxxx";            
        }
        public static void anonim2( Persona p2)
        {            
            p2.apellido = "xxxxx";                  
        }
        public static void anonim3( Persona p3)
        {            
            p3.ciudad = "xxxxx";                 
        }  
        public static void cambia(ref Persona p )
        {
            p = new Persona();
            p.nombre = "new";

            p = new Persona ();
            p.apellido = "new";

            p = new Persona();
            p.ciudad = "new";

            p = new Persona();
            p.pais = "new";         
        }
        class Program
        {
            static void multi( ref int x )
            {
                x = x * 2;
            }    
            static int suma(int x, int y)
            {
                return x+y;
            }    
            static void suma(int x, int y, out int resultado) 
            {
                resultado = x + y;
            }    
            static void Main(string[] args)
            {
                int a = 2;
                int b = 3;
                int r = suma(a,b);
                int r2;
                suma(a,b,out r2);

                Console.WriteLine(r);
                Console.WriteLine(r2);

                Persona p = new Persona();
                Console.WriteLine(p.nombre);
                Anonimo.anonim(p);
                Anonimo.cambia(ref p);

                Persona p2 = new Persona ();
                Console.WriteLine(p.apellido);
                Anonimo.anonim(p);
                Anonimo.cambia(ref p);
                
                Persona p3 = new Persona ();
                Console.WriteLine(p.ciudad);
                Anonimo.anonim(p);
                Anonimo.cambia(ref p);
            }
        }
    }
}
