using System;
using System.Collections.Generic;

namespace Publicacion
{
    abstract class Publicacion
    {
        protected string Name;
        protected string Mensaje;
        protected string Friend;
        protected string Comentario;
        protected string Zelda;
       
        public Publicacion(string N,string M,string F,string C,string Z)
        {
           this.Name = N;
           this.Mensaje = M;
           this.Friend = F;
           this.Comentario = C;
           this.Zelda = Z;
        }
        public abstract void Print();
    }

    class Estado:Publicacion
    {
        public Estado(string N, string M, string F, string C, string Z):base(N, M, F, C, Z)
        {
          
        }
        public override void Print()
        {
              Console.WriteLine("By: {0} \n Message :{1} \n Reacts: {2}\n Comments : {3}\n Zelda {4} \n (status)Les deseo Felices fiestas\n", Name, Mensaje, Friend, Comentario, Zelda);   
        }
    }
    class Fotos:Publicacion
    {
        public Fotos(string N,string M,string F,string C,string Z):base(N, M, F, C, Z)
        {
            
        }
        public override void Print()
        {
           Console.WriteLine("By: {0} \n Message :{1} \n Reacts: {2}\n Comments : {3}\n Zelda {4} \n (status)Desperdiciando oxigeno\n", Nombre, Mensaje, Friend, Comentario, Zelda);
        }
    }
    class Zelda
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var X = new Estado("Duende Melodia","Probemos el delicioso","3k Me Emperra","Es con Z.","www.myspace.com");
            X.Print();

            var Y = new Estado("Carlos Santana","Tengo que ser siempre el mejor! mejor que nadie mas!!."," 10k Me Divierte, 1 DisLike","Oni-chan.","www.miespacio.com");
            Y.Print();
        }
    }
}
