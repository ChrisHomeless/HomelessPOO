using System;
using System.Collections.Generic;

namespace Pelicula
{
    class Pelicula
    {
        private String titulo;
        private Int16 año;
        private String pais;
        private String director;
   
        public void SetTitulo(String titulo)
        {
            this.titulo=titulo;
        }

        public String GetTitulo()
        {
            return this.titulo;
        }
   
        public void SetAño(Int16 año)
        {
            this.año=año;
        }

        public Int16 GetAño()
        {
            return this.año;
        }

        public void SetPais(String pais)
        {
            this.pais=pais;
        }

        public String GetPais()
        {
            return this.pais;
        }

        public void SetDirector(String director)
        {
            this.director=director;
        }

        public String GetDirector()
        {
            return this.director;
        }
  
        public Pelicula()
        {

        }

        public Pelicula(String titulo,Int16 año,String pais,String director)
        {
            this.titulo=titulo;
            this.año=año;
            this.pais=pais;
            this.director=director;
        }

        public void Imprime()
        {
            Console.WriteLine("{0}({1}){2},{3}", this.titulo, this.año,this.pais,this.director);
        }
    }

    class Program
    {
        static void Main()
        {
           Pelicula P1 = new Pelicula();
           Pelicula P2 = new Pelicula();
          
           P1.SetTitulo("Iron Man: ");
           P1.SetAño(2008);
           P1.SetPais(" Estados Unidos");
           P1.SetDirector(" Jon Favreau");
           
           P2.SetTitulo("Batman The Dark Knight: ");
           P2.SetAño(2008);
           P2.SetPais(" Reino Unido");
           P2.SetDirector(" Christopher Nolan");

           P1.Imprime();
           P2.Imprime();           
        }
    }
}
