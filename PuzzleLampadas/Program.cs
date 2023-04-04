using System;
using Lampada;
using LampadaEstado;


namespace PuzzleLampadas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Existem 3 lampadas e 3 botões
               O primeiro botão altera o estado da primeira lampada,
               o segundo botão o estado da primeira e da segunda e
               o terceiro o estado da segunda e da terceira. */

            Lampada[] lampadas = {new Lampada("Lampada 1"), 
                                new Lampada("Lampada 2"),
                                new Lampada("Lampada 3")};

            Botao[] botoes = {new Botao(lampadas[0]),
                            new Botao(lampadas[0], lampadas[1]),
                            new Botao(lampadas[1], lampadas[2])};

            int maxpress = 6;
            for (int i = 0; i < maxpress; i++)
            {
                Console.WriteLine($"{i+1} Chance");
            }
        }
    }
}
