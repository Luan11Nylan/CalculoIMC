using System;

namespace calculo.IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imforme o peso em KG: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> abaixo do peso.");
            }
            else if ((valorIMC >= 20) && (valorIMC >= 24))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> normal.");
            }
            else if ((valorIMC >= 25) && (valorIMC >= 29))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC >= 34))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> obeso.");
            }
            else  
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> obesidade morbida.");
            }

            Console.ReadKey();
        }
    }
}
