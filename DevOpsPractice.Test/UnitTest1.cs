using DevOpsPractice.Controllers;
using DevOpsPractice.Interfaces;
using Moq;
using System;
using Xunit;

namespace DevOpsPractice.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockDependency = new Mock<ICalculate>();
            mockDependency.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(5);
            var cal = new CalulationsController(mockDependency.Object);
            var result = cal.Index(10, 30);
        }
    }
}
