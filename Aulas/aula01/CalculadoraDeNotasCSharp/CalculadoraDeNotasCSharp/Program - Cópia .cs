using System;

namespace CalculadoraDeNotasCSharp
{
    public class NotaCalculator
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double NotaPim { get; set; }

        public NotaCalculator(double nota1, double nota2, double notaPim)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            NotaPim = notaPim;
        }

        public double CalcularMedia()
        {
            return (Nota1 * 0.4) + (Nota2 * 0.4) + (NotaPim * 0.2);
        }

        public string VerificarAprovacao()
        {
            return CalcularMedia() >= 7 ? "Aluno(a) Aprovado(a)!" : "Aluno(a) Reprovado(a)!";
        }
    }
}
