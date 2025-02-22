using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    public static class ExercicioCalculadora
    {
        public static void CalculadoraSimples()
        {
            double valor1 = Utilitarios.ObterDouble("Informe o primeiro valor: ");
            Console.Write("Informe o operador (+, -, *, /): ");
            string operador = Console.ReadLine();
            double valor2 = Utilitarios.ObterDouble("Informe o segundo valor: ");

            double resultado = 0;
            bool operacaoValida = true;

            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
                Console.WriteLine($"{valor1} {operador} {valor2} = {resultado}");
        }
    }
}
