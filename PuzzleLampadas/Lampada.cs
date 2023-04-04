using System;

namespace PuzzleLampadas
{
    public enum LampadaEstado{
        Off, On
    }
    public class Lampada
    {
        public LampadaEstado Estado {get; private set;} = LampadaEstado.Off;

        public string Nome {get; private set;}
    }
}