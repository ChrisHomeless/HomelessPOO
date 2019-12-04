using System;

namespace duracion
{
    class Tiempo
    {
        private int Hts;
        private int Min;
        private int Seg;
        private int MinT;
        public Time(int H, int M, int S, int MT)
        {
            Hrs = H;
            Min = M;
            Seg = S;
            MinT = Mt;
        }
        public void print()
        {  
            Console.WriteLine("Horas :"+Hrs+" Minutos : "+Min+" Segundos :"+Seg);
            Console.WriteLine("Minutos totales :" +((Hrs*60)+Min));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time Pelicula = new Time(2,15,12,0);
            Time Cancion = new Time(0,02,15,0);
            Time Partido = new Time(2,00,10,0);

            Console.WriteLine("Pelicula");
            Pelicula.print();

            Console.WriteLine("Canción");
            Cancion.print();

            Console.WriteLine("Partido");
            Partido.print();
        }
    }
}
