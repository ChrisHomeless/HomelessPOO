using System;
using System.Collections.Generic;

namespace LifeGame
{
    enum Estado
    {
        viva, vacia
    }
    class Celula 
    {
        public Estado estado_actual;
        public Estado estado_siguiente;
        public Tablero tablero;
        public short renglon;
        public short columna;
        public Celula(Estado inicial, Tablero tablero, short renglon, short columna)
        {
            estado_actual = inicial;
            this.tablero = tablero;
            this.renglon = renglon;
            this.columna = columna;
        }
        public void actualiza_estado()
        {

        }
        public short num_vecinas()
        { 
            short cuenta = 0;

            if (renglon > 0 && columna > 0)
            {
                if (tablero.grid[renglon-1][columna-1].estado_actual == Estado.viva)
                cuenta ++;
            }
            return cuenta;
        }
        public void print()
        {
            if (this.estado_actual == Estado.vacia)
            {
                Console.Write("░");
            }
                else
            {
                Console.Write("█");
            }
        }
    }
    class Tablero
    {
        public List<List<Celula>> grid;
        public Tablero(short num_renglones, short num_columnas)
        {
            grid = new List<List<Celula>>();
            for (short i=0; i<= num_renglones-1; i++)
            {
                grid.Add(new List<Celula>());
                for (short j=0; j<=num_columnas-1; j++)
                {
                    grid[i].Add(new Celula(Estado.vacia, this, i,j));
                }
            }
        }
        public void inserta(Celula c)
        {
            grid[c.renglon][c.columna] = c;
        }
        public void print()
        {
            foreach(List<Celula> renglon in grid)
            {
                foreach(Celula c in renglon)
                {
                    c.print();
                }
                Console.WriteLine(" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tablero GoL = new Tablero(10,5);
            LG.inserta( new Celula(Estado.viva, LG, 3,3 ) );
            LG.inserta( new Celula(Estado.viva, LG, 3,2 ) );
            LG.inserta( new Celula(Estado.viva, LG, 3,1 ) );
            LG.inserta( new Celula(Estado.viva, LG, 0,0 ) );
            
            LG.print();
            Console.WriteLine(LG.grid[1][1].num_vecinas());
        }
    }
}
