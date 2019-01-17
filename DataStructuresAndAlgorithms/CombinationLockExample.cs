using BruteForce;

namespace DataStructuresAndAlgorithms
{
    public static class CombinationLockExample
    {
        public static void Run()
        {
            var combinationLock = new CombinationLock();

            int[] combo = new int[] { 0, 0, 0, 0, 0 };
            combinationLock.Unlock(combo);

            while (combinationLock.Locked)
            {
                Iterator.GetNext(combo);

                combinationLock.Unlock(combo);
            }
        }
    }
}
