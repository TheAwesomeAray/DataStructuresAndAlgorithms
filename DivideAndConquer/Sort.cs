using System;
using System.Collections.Generic;

namespace DivideAndConquer
{
    public class Sort
    {
        static Random random = new Random();
        public static List<T> QuickSort<T>(List<T> elements)
            where T : IComparable
        {
            if (elements.Count <= 1)
                return elements;

            int pivotPosition = random.Next(elements.Count);
            var smaller = new List<T>();
            var larger = new List<T>();
            for (int i = 0; i < elements.Count; i++)
            {
                if (i == pivotPosition)
                    continue;
                if (elements[i].CompareTo(elements[pivotPosition]) < 0)
                    smaller.Add(elements[i]);
                else
                    larger.Add(elements[i]);
            }

            var mergedSolution = QuickSort(smaller);
            mergedSolution.Add(elements[pivotPosition]);
            mergedSolution.AddRange(QuickSort(larger));

            return mergedSolution;
        }
    }
}
