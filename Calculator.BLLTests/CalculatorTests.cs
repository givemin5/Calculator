using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BLL.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest_First_1_Second_2_Return_3()
        {
            //Arrange
            int first = 1;
            int second = 2;
            int expected = 3;
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Add(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}