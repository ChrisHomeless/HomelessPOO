using System;
using System.Collections.Generic;

namespace ilustrador
{
    abstract class Figura 
	{
		protected int x;
		protected int y;
		protected string color;
		public Figura(int x, int y, string c) 
        {
			this.x = x; this.y = y; color = c;
		}
		public void printColor() 
        {
			Console.WriteLine(color);
		}
		public abstract void dibuja();
	}
	class Circulo : Figura
	{
		public Circulo(int x, int y, string c):base(x , y, c)
        {

		}
		public override void dibuja()
        {
			Console.WriteLine("Se dibuja un circulo {0}", this.color);
		}
	}
	class Rect : Figura
	{
		public Rect(int x, int y, string c):base(x , y, c)
        {

		}
		public override void dibuja()
        {
			Console.WriteLine("Se dibuja un rectangulo {0}", this.color);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Figura> figuras = new List<Figura>();
			figuras.Add(new Circulo(12,13,"verde"));
			figuras.Add(new Rect(12,13,"azul"));
			figuras.Add(new Rect(12,13,"rojo"));
			figuras.Add(new Circulo(12,13,"rojo"));

			foreach (var item in figuras)
            {
				item.dibuja();
			}
		}
	}
}
