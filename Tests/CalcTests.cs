using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CalcTests
    {
        [DataRow(4, 1, 3)]
        [DataRow(5, 4, 1)]
        [DataRow(26, 24, 2)]
        [TestMethod]
        public void Substract_ShouldCalcAndReturnSameValue(int a, int b, int expected)
        {
            //Arrange
            //int a = 4
            //int b = 1
            //expected = 3

            //Act
            int actual = Calcs.Substract(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
