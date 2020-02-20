using System;

namespace SimpleLogic
{
    public struct Bit
    {
        bool value;

        public static implicit operator bool(Bit b) => b.value;
        public static implicit operator Bit(bool b) => new Bit { value = b };

        public static implicit operator int(Bit i) => i.value ? 1 : 0;
        public static implicit operator Bit(int i) => new Bit { value = i != 0 };
    }
}
