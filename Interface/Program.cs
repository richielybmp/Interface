using System;
using static Interface.Framework;

namespace Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");
            Carro carro = new Carro() { Nome = "HB20", ID = "0" };
            Console.WriteLine(carro.ToString());
            carro.EntrarNoCarro();
            carro.Ligar();
            Console.ReadLine();
        }
    }
}
