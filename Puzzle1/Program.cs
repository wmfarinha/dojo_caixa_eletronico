using System;

namespace Puzzle1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var caixaEletronico = new CaixaEletronico();
            Console.Write("Informe um valor para saque: ");
            var inputValue = Console.ReadLine();
            var notas = caixaEletronico.Saque(Convert.ToInt32(inputValue));
            Console.WriteLine($"DEZ:{notas.NotaDez} | VINTE:{notas.NotaVinte} | CINQUENTA:{notas.NotaCinquenta} | CEM:{notas.NotaCem}");
        }
    }
}
