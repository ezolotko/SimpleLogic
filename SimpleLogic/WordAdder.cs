using System;

namespace SimpleLogic
{
    public static class WordAdder
    {
        public static Word Add(Word a, Word b)
        {
            var r = Add(a, b, 0);
            if (r.carryOut)
                throw new OverflowException();

            return r.sum;
        }

        public static (Word sum, Bit carryOut) Add(Word a, Word b, Bit cIn)
        {
            var r0 = BitAdder.Add(a.b0, b.b0, cIn);
            var r1 = BitAdder.Add(a.b1, b.b1, r0.carryOut);
            var r2 = BitAdder.Add(a.b2, b.b2, r1.carryOut);
            var r3 = BitAdder.Add(a.b3, b.b3, r2.carryOut);

            return (new Word(r0.sum, r1.sum, r2.sum, r3.sum), r3.carryOut);
        }
    }
}