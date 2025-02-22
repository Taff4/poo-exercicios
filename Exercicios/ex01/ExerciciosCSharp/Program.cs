using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Menu de Exercícios ===");
                Console.WriteLine("1 - Converter metros para centímetros e milímetros");
                Console.WriteLine("2 - Converter Fahrenheit para Celsius");
                Console.WriteLine("3 - Calculadora simples");
                Console.WriteLine("4 - Cálculo de pagamento em loja");
                Console.WriteLine("5 - Cálculo de área de terreno retangular");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        ExercicioConversoes.ConverterMetros();
                        break;
                    case "2":
                        ExercicioConversoes.ConverterFahrenheit();
                        break;
                    case "3":
                        ExercicioCalculadora.CalculadoraSimples();
                        break;
                    case "4":
                        ExercicioPagamento.PagamentoLoja();
                        break;
                    case "5":
                        ExercicioAreaTerreno.CalcularAreaTerreno();
                        break;
                    case "0":
                        sair = true;
                        continue;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
