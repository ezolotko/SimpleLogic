using System;

namespace SimpleLogic
{
    public static class Ops
    {
        public static Bit Nand(Bit a, Bit b) => !(a && b);

        public static Bit Not(Bit v) => Nand(v, v);
        public static Bit And(Bit a, Bit b) => Not(Nand(a, b));
        public static Bit Or(Bit a, Bit b) => Nand(Not(a), Not(b));
        public static Bit Xor(Bit a, Bit b) => Or(And(a, Not(b)), And(Not(a), b));
    }
}
