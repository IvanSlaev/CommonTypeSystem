namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong _number;

        private int[] _bits;

        public BitArray64(ulong number)
        {
            this._number = number;
            string binary = Convert.ToString((long)number, 2).PadLeft(64, '0');
            _bits = new int[binary.Length];
            for (int i = 0; i < binary.Length; i++)
            {
                _bits[i] = int.Parse(binary[i].ToString());
            }
        }

        public ulong Number => _number;

        
        public IEnumerator<int> GetEnumerator()
        {
            for (int index = 0; index < _bits.Length; index++)
            {
                int bit = this._bits[index];
                yield return bit;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            for (int index = 0; index < _bits.Length; index++)
            {
                if (_bits[64 - index - 1] != (obj as BitArray64)[index])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public override int GetHashCode()
        {
            return this._number.GetHashCode() ^ _bits.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 && index > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this._bits[64 - index - 1];
            }
        } 
    }
}
