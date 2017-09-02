using System;

namespace Interface
{
    public static class Framework
    {
        interface ICarro
        {
            void Ligar();
            void Acelerar();
            void Freiar();
            void Desligar();
        }

        interface IMotorista
        {
            void EntrarNoCarro();
        }

        // uma classe implementa uma interface
        public class Automóvel : ICarro
        {
            public void Acelerar()
            {
                Console.WriteLine("Acelerando");
            }

            public void Desligar()
            {
                Console.WriteLine("Desligando Carro...");
            }

            public void Freiar()
            {
                Console.WriteLine("Freiando...");
            }

            public void Ligar()
            {
                Console.WriteLine("Ligando Carro...");
            }
        }

        // burlar herança multipla, ao inves de herdar de várias classes, intancia um objeto privado e utiliza seus métodos implementados da interface
        //public class Carro : Automóvel, IMotorista
        public class Carro : IMotorista
        {
            private Automóvel _Automovel = new Automóvel();

            public string Nome { get; set; }
            public string ID { get; set; }

            // delegação, para usar o método acelerar do objeto Automovel
            // implemento 
            public void Ligar()
            {
                // o metodo acelerar é implemntação da ICarro em Automovel
                this._Automovel.Ligar();
            }

            public void DesligarAlarme()
            {
                Console.WriteLine("Desligando alarme... ");
            }

            public void EntrarNoCarro()
            {
                Console.WriteLine("Motorista está no carro");
            }

            public void LigarAlarme()
            {
                Console.WriteLine("Ligando alarme...");
            }

            public override string ToString()
            {
                return "Carro: " + this.Nome + ". ID: " + this.ID;
            }
        }
    }
}
