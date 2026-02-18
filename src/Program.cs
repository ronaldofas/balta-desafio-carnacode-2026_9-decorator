using System;
using Refactored = DesignPatternChallenge.Refactored;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CarnaCode 2026 - Desafio Decorator");
            Console.WriteLine("Selecione a versão para executar:");
            Console.WriteLine("1. Legado (Explosão de Classes)");
            Console.WriteLine("2. Refatorado (Decorator Pattern)");
            Console.Write("Opção: ");

            var option = Console.ReadLine();

            if (option == "1")
            {
                // Executa o método legado (agora renomeado para RunLegacy)
                LegacyProgram.RunLegacy();
            }
            else if (option == "2")
            {
                Console.WriteLine("\n--- Pedidos Refatorados (Decorator Pattern) ---");

                // Pedido 1: Espresso sem nada
                // Usando alias 'Refactored' para evitar ambiguidade com a classe Espresso do legado
                Refactored.Beverage bebida1 = new Refactored.Espresso();
                Console.WriteLine($"{bebida1.Description} R$ {bebida1.Cost():N2}");

                // Pedido 2: Espresso com Leite e Chocolate (Mocha?)
                Refactored.Beverage bebida2 = new Refactored.Espresso();
                bebida2 = new Refactored.Leite(bebida2);
                bebida2 = new Refactored.Chocolate(bebida2);
                Console.WriteLine($"{bebida2.Description} R$ {bebida2.Cost():N2}");

                // Pedido 3: Cappuccino com Chantilly e Caramelo
                Refactored.Beverage bebida3 = new Refactored.Cappuccino();
                bebida3 = new Refactored.Chantilly(bebida3);
                bebida3 = new Refactored.Caramelo(bebida3);
                Console.WriteLine($"{bebida3.Description} R$ {bebida3.Cost():N2}");
                
                // Pedido 4: Chá com Leite (estilo britânico)
                Refactored.Beverage bebida4 = new Refactored.Cha();
                bebida4 = new Refactored.Leite(bebida4);
                Console.WriteLine($"{bebida4.Description} R$ {bebida4.Cost():N2}");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
