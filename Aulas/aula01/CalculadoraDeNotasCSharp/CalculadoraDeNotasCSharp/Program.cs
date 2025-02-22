using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraDeNotasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora de Notas ===");

            double nota1 = ObterNota("Informe a Nota 1: ");
            double nota2 = ObterNota("Informe a Nota 2: ");
            double notaPim = ObterNota("Informe a Nota do PIM: ");

            NotaCalculator calculadora = new NotaCalculator(nota1, nota2, notaPim);
            double media = calculadora.CalcularMedia();
            string resultado = calculadora.VerificarAprovacao();

            Console.WriteLine($"\nMédia Semestral: {media:F2}");
            Console.WriteLine(resultado);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static double ObterNota(string mensagem)
        {
            double nota;
            while (true)
            {
                Console.Write(mensagem);
                string input = Console.ReadLine();

                if (double.TryParse(input, out nota) && nota >= 0 && nota <= 10)
                    return nota;

                Console.WriteLine("Entrada inválida. Digite um número entre 0 e 10.");
            }
        }
    }
}
