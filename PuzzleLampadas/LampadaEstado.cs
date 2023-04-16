using System;

namespace LampadaEstado
{
    [Flags]
    enum lampadas
    {
        Lampada_direita = 1 << 0, // 1
        Lampada_meio = 1 << 1, // 2
        Lampada_esquerda = 1 << 2 // 4
    }
}