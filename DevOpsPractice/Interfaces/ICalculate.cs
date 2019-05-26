using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsPractice.Interfaces
{
    public interface ICalculate
    {
        int Add(int a , int b);
        int SumOfIntegerList(IEnumerable<int> a);
    }
}
