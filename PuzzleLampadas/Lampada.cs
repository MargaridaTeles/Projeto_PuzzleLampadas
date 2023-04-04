using System;

namespace PuzzleLampadas
{
    public class Lampada
    {
        public LampadaEstado Estado {get; private set;} = Off;

        public string Nome {get; private set;}
    }
}