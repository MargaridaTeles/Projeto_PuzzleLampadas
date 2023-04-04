using System;

namespace PuzzleLampadas
{
    public class Lampada
    {
        public LampadaEstado Estado {get; private set;} = LampadaEstado.Off;

        public string Nome {get; private set;}
    }
}