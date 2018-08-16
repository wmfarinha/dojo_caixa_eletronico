namespace Puzzle1
{
    public struct Notas
    {
        public int NotaDez { get; }
        public int NotaVinte { get; }
        public int NotaCinquenta { get; }
        public int NotaCem { get; }

        public Notas(int notaDez, int notaVinte, int notaCinquenta, int notaCem)
        {
            NotaDez = notaDez;
            NotaVinte = notaVinte;
            NotaCinquenta = notaCinquenta;
            NotaCem = notaCem;
        }
    }
}
