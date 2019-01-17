using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteForce
{
    public class BruteForceSolver
    {
        private CombinationLock _comboLock { get; set; }
        private List<int> _currentCombination { get; set; } 

    public BruteForceSolver(CombinationLock comboLock)
        {
            _comboLock = comboLock;
            _currentCombination = new List<int>(Enumerable.Repeat(0, _comboLock.LockSize));
        }

        public void Break()
        {
            int addingIndex = 0;
            int highestIndexReached = 0;

            while (_comboLock.Locked)
            {
                if (_currentCombination[addingIndex] == 9)
                {
                    addingIndex++;

                    //if ()
                    //combination[workingIndex]++;

                    //while (workingIndex > 0)
                    //{
                    //    workingIndex--;
                    //    combination[workingIndex] = 0;
                    //}
                }

               // _comboLock.Unlock(new Combination(_currentCombination));

                if (_comboLock.Locked)
                    _currentCombination[addingIndex]++;
            }
        }
    }
}
