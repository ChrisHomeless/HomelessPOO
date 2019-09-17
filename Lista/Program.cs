using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lista = new List<String>();

                lista.Add("1.- ScarFace");
                lista.Add("2.- Marte");
                lista.Add("3.- Interestelar");
                lista.Add("4.- El laberinto del fauno");
                lista.Add("5.- El exorcista");

           foreach(String Pelicula in lista)
           
                Console.WriteLine(Pelicula);
        }
    }
}
