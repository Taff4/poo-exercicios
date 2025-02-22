using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    public static class ExercicioPagamento
    {
        public static void PagamentoLoja()
        {
            double total = Utilitarios.ObterDouble("Informe o total gasto pelo cliente: ");
            Console.WriteLine("Opções de pagamento:");
            Console.WriteLine("1 - A vista com 10% de desconto");
            Console.WriteLine("2 - Em duas vezes (sem desconto)");
            Console.Write("Escolha a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    double valorAVista = total * 0.9;
                    Console.WriteLine($"Valor à vista (10% de desconto): {valorAVista:F2}");
                    break;
                case "2":
                    double parcela = total / 2;
                    Console.WriteLine($"Valor total: {total:F2}. Duas parcelas de: {parcela:F2}");
                    break;
                default:
                    Console.WriteLine("Opção inválida de pagamento.");
                    break;
            }
        }
    }
}
