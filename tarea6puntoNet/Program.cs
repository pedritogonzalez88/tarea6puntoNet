using System;

namespace tarea6puntoNet
{
    class Program
    {
        static void Main()
        {
            //generar un numero aleatorio del 1 al 20
            var numeroSecreto = new Random(DateTime.Now.Second).Next(1, 21);
            var numeroIngresado = 0;
            var intentos = 0;
            
                while (numeroSecreto != numeroIngresado)
                {
                    intentos++;
                    Console.WriteLine("Intento {0}", intentos);
                    Console.WriteLine("Ingrese un numero del 1 al 20");
                    numeroIngresado = int.Parse(Console.ReadLine());
                    
                    if (numeroSecreto == numeroIngresado)
                    {
                        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}"+$" Lo has logrado en {intentos} intentos!!");
                    }
                    else if (numeroSecreto > numeroIngresado)
                    {
                        Console.WriteLine("El numero secreto es mayor, porfavor vuelva a Intentarlo nuevamente ");
                    }else
                    {
                       Console.WriteLine("El numero secreto es menor, por favor vuelva a intentar nuevamente.");
                    }
                    
                }

            Console.ReadKey();
        }
    }
}
