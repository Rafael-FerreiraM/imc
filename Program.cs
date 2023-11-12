using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peso
            Console.Write("Digite o seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            //Altura
            Console.Write("Digite a sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            //IMC
            double imc = peso / (altura * altura);

            //Condicionais para verificar o IMC
            if (imc < 18.5)
            {
                Console.Write("Abaixo do peso ");

            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.Write("Peso Ideal ");

            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.Write("Sobrepeso ");

            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.Write("Obesidade grau I ");

            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.Write("Obesidade grau II ");

            }
            else if (imc >= 40)
            {
                Console.Write("Obesidade grau III ");

            }



            Console.ReadKey();
        }
    }
}