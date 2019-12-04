using System;
using System.Collections.Generic;

namespace musico
{
    class Musico
    {
        protected string Name;
        public Musico(string N)
        {
            Name = N;
        }
        public virtual void Saludar()
        {
            Console.WriteLine("Hola, que tal? soy {0}",Name);
        }
        public virtual void Afinar()
        {
            Console.WriteLine("{0},Afinando su instrumento {0}",Name);
        }
        class Bajista:Musico
        {
            private string Bass;
            public Bajista(string no,string B):base(no)
            {
                this.Bass = B;
            }
            public override void Afinar()
            {
                Console.WriteLine("{0} Afinando su {1}", Name, Bass);
            }
        }
        class Guitarrista:Musico
        {
            private string Guitar;
            public Guitarrista(string no, string G):base(no)
            {
                this.Guitar = G;
            }
            public override void Afinar()
            {
                Console.WriteLine("{0} Afinando su {1}", Name, Guitar);
            } 
            class Baterista:Musico
            {
                private string Bateria;
                public Baterista(string no, string V):base(no)
                {
                    this.Bateria = Bt;
                }
                public override void Afinar()
                {
                    Console.WriteLine("{0} Afinando su {1}",Name,Bateria);
                } 
            }
            class Program
            {
                static void Main(string[] args)
                {
                    Musico Tomas=new Musico("Tomas");
                    Bajista flea=new Bajista("Flea","Bateria");
                    Guitarrista JSenoue=new Guitarrista("JSenoue","Guitarra");
                    Baterista IDK =new Baterista("IDK","Bateria");

                    List <Musico> grupo = new List <Musico>();
                    grupo.Add(Tomas);
                    grupo.Add(flea);
                    grupo.Add(JSenoue);
                    grupo.Add(IDK);

                    foreach(Musico m in grupo)
                    {
                        m.Saludar();
                        m.Afinar();
                        Console.WriteLine(" ");
                    }            
                }
            }
        }
    }
}
