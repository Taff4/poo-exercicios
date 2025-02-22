using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    public static class Utilitarios
    {
        // Método para obter um valor double com tratamento de erro
        public static double ObterDouble(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.Write(mensagem);
                string input = Console.ReadLine();
                if (double.TryParse(input, out valor))
                    return valor;
                else
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }
}
