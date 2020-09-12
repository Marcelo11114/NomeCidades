using System;

namespace NomeCidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("+---------------------------+ ");
            Console.WriteLine("|CIDADES DO LITORAL PAULISTA| ");
            Console.WriteLine("+---------------------------+ ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     Santos\n     São Vicente\n     Praia grande\n     Guaruja\n     Cubatão\n     Caragua\n     Itanhaem\n     Ubatuba\n     São Sebastião\n     Peruibe\n     Bertioga\n     Mongagua\n     Ilha Bela\n     Iguape\n     Cananeia\n     Ilha Comprida");
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  Qualquer Tecla para sair");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

        }
    }
}


