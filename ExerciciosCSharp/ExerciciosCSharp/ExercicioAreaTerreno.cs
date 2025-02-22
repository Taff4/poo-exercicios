using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciciosCSharp
{
    public static class ExercicioAreaTerreno
    {
        public static void CalcularAreaTerreno()
        {
            double comprimento = Utilitarios.ObterDouble("Informe o comprimento do terreno (em metros): ");
            double largura = Utilitarios.ObterDouble("Informe a largura do terreno (em metros): ");
            double area = comprimento * largura;
            Console.WriteLine($"A área do terreno é: {area} metros quadrados.");
        }
    }
}
