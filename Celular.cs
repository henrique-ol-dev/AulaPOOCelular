using System;
namespace Celular
{
    public class Celular
    {
       
        public string cor="Vermelho";

        public string modelo="motorola";

        public bool ligado=true;

        public void Ligar(){

            Console.WriteLine("Celular ligando...");
            ligado=true; 
                       
        }
        public void Desligar(){

            Console.WriteLine("Celular Desligando...");
            ligado=false; 
                       
        }
        

        public void EnviarMensagem(){

            Console.WriteLine("Mensagem");

        }

        public void Ligacao(){

            Console.WriteLine("Ligando");

        }

        


    }
}