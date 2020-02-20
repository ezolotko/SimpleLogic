using System;

namespace SimpleLogic
{
    public static class WordConverter
    {
        public static Word ToWord(int v)
        {
            if (v < 0 || v > 15)
                throw new ArgumentOutOfRangeException();

            return new Word(
                (v & (1 << 0)) != 0,
                (v & (1 << 1)) != 0,
                (v & (1 << 2)) != 0,
                (v & (1 << 3)) != 0);
        }

        public static int FromWord(Word v) =>
            (1 * v.b0) + (2 * v.b1) + (4 * v.b2) + (8 * v.b3);
    }
}