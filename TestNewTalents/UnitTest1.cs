using System;
using Xunit;
using NewTalents;

namespace UnitTest
{
    public class UnitTest1
    {
        public Calculator buildClass()
        {
            string data = "21/02/2024";
            Calculator calc = new Calculator(data);

            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        [InlineData (1, -3, -2)] 
        public void TestAddition(int number1, int number2, int result)
        {
            Calculator calc = buildClass();

            int calcResult = calc.addition(number1, number2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData (5, 2, 3)]
        [InlineData (4, 3, 1)]
        [InlineData (1, 5, -4)]  
        public void TestSubtraction(int number1, int number2, int result)
        {
            Calculator calc = buildClass();

            int calcResult = calc.subtraction(number1, number2);

            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData (2, 2, 4)]
        [InlineData (4, 5, 20)] 
        [InlineData (2, -3, -6)] 
        public void TestMultiplication(int number1, int number2, int result)
        {
            Calculator calc = buildClass();

            int calcResult = calc.multiplication(number1, number2);

            Assert.Equal(result, calcResult);
        }
        [Theory]
        [InlineData (10, 5, 2)]
        [InlineData (6, 3, 2)]
        [InlineData (-2, 2, -1)] 
        public void TestDivision(int number1, int number2, int result)
        {
            Calculator calc = buildClass();

            int calcResult = calc.division(number1, number2);

            Assert.Equal(result, calcResult);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Calculator calc = buildClass();

            Assert.Throws<DivideByZeroException>(
                () => calc.division(3,0)
                );
        }

        [Fact]
        public void TestHistoric()
        {
            Calculator calc = buildClass();

            calc.addition(1, 2);
            calc.addition(2, 8);
            calc.addition(3, 7);
            calc.addition(4, 2);

            var list = calc.historic();

            Assert.NotEmpty(calc.historic());
            Assert.Equal(3, list.Count);
        }

    }
}
