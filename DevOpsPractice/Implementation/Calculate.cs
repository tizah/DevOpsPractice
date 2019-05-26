using DevOpsPractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsPractice.Implementation
{
    public class Calculate : ICalculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int SumOfIntegerList(IEnumerable<int> a)
        {
            return a.Sum();
        }
    }
}
