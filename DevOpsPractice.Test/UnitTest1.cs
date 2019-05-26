using DevOpsPractice.Controllers;
using DevOpsPractice.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DevOpsPractice.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockDependency = new Mock<ICalculate>();
            mockDependency.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(40);
            var cal = new CalulationsController(mockDependency.Object);
            var result = cal.Index(10, 30);
            Assert.Equal(40,result);
        }


        [Fact]
        public void Test_for_sum_OfAnd_Array()
        {
            int[] array = new int[] { 2, 4, 4 };
            var mockDependency = new Mock<ICalculate>();
            mockDependency.Setup(x => x.SumOfIntegerList(It.IsAny<IEnumerable<int>>())).Returns(10);
            var cal = new CalulationsController(mockDependency.Object);
            var result = cal.GetSumOfIntegers(array);
            Assert.Equal(10, result);

        }
    }
}
