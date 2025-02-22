using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    public static class ExercicioConversoes
    {
        // Exercício 1: Converter metros para centímetros e milímetros
        public static void ConverterMetros()
        {
            double metros = Utilitarios.ObterDouble("Informe um valor em metros: ");
            double centimetros = metros * 100;
            double milimetros = metros * 1000;
            Console.WriteLine($"{metros} metro(s) equivalem a {centimetros} centímetros e {milimetros} milímetros.");
        }

        // Exercício 2: Converter Fahrenheit para Celsius
        public static void ConverterFahrenheit()
        {
            double fahrenheit = Utilitarios.ObterDouble("Informe um valor em graus Fahrenheit: ");
            double celsius = (fahrenheit - 32.0) * (5.0 / 9.0);
            Console.WriteLine($"{fahrenheit}°F equivalem a {celsius:F2}°C.");
        }
    }
}
