using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projBitABit
{
    class Bits
    {
        private byte osBits; // 0..255 => 00000000..11111111 => 0x00..0XFF

        public Bits()
        {
            this.osBits = 0;
        }

        public Bits(byte osBits)
        {
            this.osBits = osBits;
        }

        public void setBits(byte osBits)
        {
            this.osBits = osBits;
        }

        public byte getBits()
        {
            return this.osBits;
        }

        public bool getBits(int bit)
        {
            byte novoDado;
            int valor;
            valor = (int)Math.Pow(2, bit - 1);
            novoDado = (byte)((int)this.osBits & valor);
            return (novoDado > 0);
        }

        public void setBit1(int bit)
        {
            int valor;
            valor = (int)Math.Pow(2, bit - 1);
            this.osBits = (byte)((int)this.osBits | valor);
        }

        public void setBit0(int bit)
        {
            int valor;
            valor = 255 - (int)Math.Pow(2, bit - 1);
            this.osBits = (byte)((int)this.osBits & valor);
        }
    }
}
