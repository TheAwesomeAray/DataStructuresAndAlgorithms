using System;
using System.Linq;

namespace BruteForce
{
    public class CombinationLock
    {
        Random random { get; set; } = new Random();
        private Combination _combination { get; set; }
        public bool Locked { get; private set; }
        public int LockSize { get; private set; } = 5;

        public CombinationLock()
        {
            ResetLock();
        }

        public void ResetLock()
        {
            _combination = new Combination(new[]
            {
                GetRandomLockPosition(),
                GetRandomLockPosition(),
                GetRandomLockPosition(),
                GetRandomLockPosition(),
                GetRandomLockPosition()
            });

            Locked = true;
        }

        private int GetRandomLockPosition()
        {
            return random.Next(0, 9);
        }

        public void Unlock(int[] combination)
        {
            if (_combination.Equals(new Combination(combination)))
                Locked = false;
        }

        public void Lock()
        {
            Locked = true;
        }
    }
}
