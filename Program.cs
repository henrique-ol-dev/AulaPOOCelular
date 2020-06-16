using System;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
                   

            // NomeDaClass nomeQualquer = new NomeDaClass();

            Celular LG = new Celular();

            Console.WriteLine("Deseja ligar o celular S/N");
            string valor=Console.ReadLine();

            
            if(valor == "S"){

                LG.Ligar();

            }
            

           if(LG.ligado == true){

               LG.EnviarMensagem();
               LG.Ligacao();
               

           }else{
               LG.Desligar();
           }
            



        }
    }
}
