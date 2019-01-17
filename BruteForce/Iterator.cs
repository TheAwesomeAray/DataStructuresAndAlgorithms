namespace BruteForce
{
    public static class Iterator
    {
        public static void GetNext(int[] combination)
        {
            int index = 0;

            while (index < 5 && combination[index] == 9)
            {
                combination[index] = 0;
                index++;
            }

            combination[index]++;
        }
    }
}
