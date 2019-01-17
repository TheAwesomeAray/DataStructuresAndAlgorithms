using System;

namespace BruteForce
{
    public class Combination : IEquatable<Combination>
    {
        private int[] _positions;

        public Combination(int[] positions)
        {
            _positions = positions;
        }

        public bool Equals(Combination other)
        {
            if (other._positions.Length != _positions.Length)
                return false;

            for (int i = 0; i < _positions.Length; i++)
            {
                if (_positions[i] != other._positions[i])
                    return false;
            }

            return true;
        }
    }
}
