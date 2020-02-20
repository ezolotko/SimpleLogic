using System;

using static SimpleLogic.Ops;

namespace SimpleLogic
{
    public static class BitAdder
    {
        public static Bit CarryOut(Bit a, Bit b, Bit carryIn) =>
            Or(Or(And(a, b), And(a, carryIn)), Or(And(a, carryIn), And(b, carryIn)));

        public static Bit Sum(Bit a, Bit b, Bit carryIn) => Xor(Xor(a, b), carryIn);

        public static (Bit sum, Bit carryOut) Add(Bit a, Bit b, Bit carryIn) =>
            (Sum(a, b, carryIn), CarryOut(a, b, carryIn));
    }
}
