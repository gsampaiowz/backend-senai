using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cellphone
{
    public class Celular
    {
        public string cor = string.Empty;
        public string modelo = string.Empty;
        public string tamanho = string.Empty;
        public bool ligado;

        public void Ligar()
        {
            Console.WriteLine($"\nLigando...");
            Thread.Sleep(2000);
            Console.WriteLine($"\nLigado!");
        }
        public void Desligar()
        {
            Console.WriteLine($"\nDesligando...");
            Thread.Sleep(2000);
            Console.WriteLine($"\nDesligado.");
            ligado = false;
        }
        public void FazerLigacao()
        {
            Console.WriteLine($"\nDigite para qual número deseja ligar: ");
            Console.ReadLine();
            Console.WriteLine($"\nRealizando ligação...");
            Thread.Sleep(2000);
            Console.WriteLine($"\nLigação recusada.");
        }
        public void EnviarMensagem()
        {
            Console.WriteLine($"\nDigite para qual número deseja mandar mensagem: ");
            Console.ReadLine();
            Console.WriteLine($"\nDigite a mensagem: ");
            Console.ReadLine();
            Console.WriteLine($"\nMandando a mensagem...");
            Thread.Sleep(2000);
            Console.WriteLine($"\nMensagem enviada.");
        }
    }
}