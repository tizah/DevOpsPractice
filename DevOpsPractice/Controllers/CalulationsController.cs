﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsPractice.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsPractice.Controllers
{
    /// <summary>
    /// //
    /// </summary>
    public class CalulationsController
    {
        private readonly ICalculate _math;
        public CalulationsController(ICalculate math)
        {
            _math = math;
        }
        public int Index( int a , int b)
        {
            var sum = _math.Add(a,b);
            return sum;
        }

        public int GetSumOfIntegers(IEnumerable<int> a)
        {
            return _math.SumOfIntegerList(a);
        }


    }
}