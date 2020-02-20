namespace SimpleLogic
{
    public struct Word
    {
        public Bit b0;
        public Bit b1;
        public Bit b2;
        public Bit b3;

        public Word(Bit b0, Bit b1, Bit b2, Bit b3)
        {
            this.b0 = b0;
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
    }
}