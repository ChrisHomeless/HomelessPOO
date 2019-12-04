using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Pelicula
	    {	        
	        private String Titulo;
	        private Int16 Año;
	        private string Pais;
	        private string Director;		        
	        public void SetTitulo(string Titulo)
	        {
	            this.Titulo = Titulo;
	        } 
	        public string GetTitulo()
	        {
	            return this.Titulo;
	        }
	        public void SetAño(Int16 Año)
	        {
	            this.Año = Año;
	        } 
	        public Int16 GetAño()
	        {
	            return this.Año;
	        }
              public void Setpais(string Pais)
	        {
	            this.Pais = Pais;
	        } 
	        public string Getpais()
	        {
	            return this.Pais;
	        }
	        public void SetDirector(string Director)
	        {
	            this.Director = Director;
	        } 
	        public String GetDirector()
	        {
	            return this.Director;
	        }
	        public Pelicula()
	        {
	
	        }
	        public Pelicula(String Titulo, Int16 Año,String Pais,String Director)
	        {
	            this.Titulo = Titulo;
	            this.Año = Año;
                this.Pais = Pais;
                this.Director = Director;
	        }	        
	        public void Imprime()
	        {
	            Console.WriteLine("Titulo: {0}\nAño: {1}\nPais:{2}\nDirector:{3}\n", this.Titulo, this.Año,this.Pais,this.Director);
	        }
	    }
	    class Program
	    {
	        static void Main(String[] args)
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
	            	            
	            List<Pelicula> peliculas = new List<Pelicula>();
	            peliculas.Add(new Pelicula("Iron man 2: ", 2010,"Estados Inidos","Jon Favreau"));
	            peliculas.Add(new Pelicula("Batman Dark knight Returns",2012,"Estados Unidos","Benjamin Melniker"));
	            peliculas.Add(new Pelicula("Sirenita ", 1989,"Estados Unidos","Ron Clements"));
              	            
	            foreach(Pelicula p in peliculas)
	            {
	                p.Imprime();
	            }	            
	        }
	    }
	}
