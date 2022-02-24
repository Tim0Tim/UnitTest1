using System;
using Xunit;
using CalculatorDemo;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            //Assemble
            Calculator calc = new Calculator();

            //Act
            int answer = calc.Add(1, 2);

            //Assert
            Assert.Equal(3, answer);
        }

        [Fact]
        public void AddTestFailing()
        {
            //Assemble
            Calculator calc = new Calculator();

            //Act
            int answer = calc.Add(4, 5);

            //Assert
            Assert.Equal( 9, answer);
        }

        [Fact]
        public void SubtractTest()
        {
            //Assemble
            Calculator calc = new Calculator();

            //Act
            int answer1 = calc.Subtract(6, 2);
            int answer2 = calc.Subtract(1, 2);
            int answer3 = calc.Subtract(0, 0);

            //Assert
            Assert.Equal(4, answer1);
            Assert.Equal(-1, answer2);
            Assert.Equal(0, answer3);
        }
    }
}
