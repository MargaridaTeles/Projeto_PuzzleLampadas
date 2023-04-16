using System;

namespace LampadaEstado
{
    /// <summary>
    /// Cada membro representa bit numa sequência de bits
    /// Atributo [Flags] indica que enum pode ser tratada como conjunto de bits
    /// Permite ativar/desativar características bit a bit
    /// </summary>
    [Flags]
    enum lampadas
    {
        Lampada_direita = 1 << 0, // 1
        Lampada_meio = 1 << 1, // 2
        Lampada_esquerda = 1 << 2 // 4
    }
}