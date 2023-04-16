using System;
using System.Linq;
using LampadaEstado;

namespace PuzzleLampadas
{
    class Program
    {
        public static lampadas LampadasLigadas = 0;
        
        static void Main(string[] args)
        {
            /* Existem 3 lampadas e 3 botões
               O primeiro botão altera o estado da primeira lampada,
               o segundo botão o estado da primeira e da segunda (se ambos forem diferentes) e
               o terceiro o estado da segunda e da terceira. (se ambos forem diferentes)
               
                Objetivo: Ligar todas as lâmpadas apenas carregando
                no máximo 6 vezes nos botões.
            */
            string[] Lampadas = {"Lampada Esquerda", "Lampada Meio", "Lampada Direita"};
            string[] Botoes = {"1", "2", "3"};

            Console.WriteLine("\nObjetivo: Ligar todas as lâmpadas apenas carregando no máximo 6 vezes nos botões.");
            int maxpress = 0;
            bool ganhou = false;

            while (maxpress < 6)
            {
                Console.WriteLine($"\n--- {maxpress+1}º Chance ---\n");
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"{Lampadas[k]}       ");
                }
                Console.WriteLine("");
                for(int j = 0; j < 3; j++)
                {   
                    Console.Write($"    Botão {Botoes[j]}           ");
                }
                Console.Write("\n\nEscolha um botão de 1 a 3: ");
                string input = Console.ReadLine();
                while(!(input == Botoes[0] || input == Botoes[1] || input == Botoes[2]))
                {
                    Console.Write("Por favor escolha um botão de 1 a 3: ");
                    input = Console.ReadLine();
                }
                if(input == "1")
                {
                    LampadasLigadas ^= lampadas.Lampada_esquerda;
                }
                if(input == "2")
                {
                    if(new[] {0, 6}.Contains((int)(LampadasLigadas & (lampadas.Lampada_meio | lampadas.Lampada_esquerda))))
                    {
                        Console.WriteLine("Ligou Esquerda e Meio!");
                    }
                    else
                    {
                        LampadasLigadas ^= lampadas.Lampada_esquerda;
                        LampadasLigadas ^= lampadas.Lampada_meio;
                    }
                }
                if(input == "3")
                {
                    if(new[] {0, 3}.Contains((int)(LampadasLigadas &(lampadas.Lampada_meio | lampadas.Lampada_direita))))
                    {
                        Console.WriteLine("Ligou Meio e Direita!");
                    }
                    else
                    {
                        LampadasLigadas ^= lampadas.Lampada_meio;
                        LampadasLigadas ^= lampadas.Lampada_direita;
                    }
                }
                
                Console.WriteLine($"Ligou: {LampadasLigadas}");
                maxpress++;
            }
            
            if( (int)LampadasLigadas == 3 && maxpress <= 6 )
            {
                ganhou = true;
                Console.WriteLine($"\nPUZZLE RESOLVIDO!! Em {maxpress} carregamentos!");
            }
            else
            {
                Console.WriteLine("\n\nPERDEU!");
            }
        }
        
    }
}
