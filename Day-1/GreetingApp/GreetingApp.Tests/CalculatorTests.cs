using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace GreetingApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Should_Be_Able_To_Add_Two_Numbers()
        {
            //Arrange
            var calculator = new Calculator();
            var number1 = 10;
            var number2 = 20;
            var expectedResult = 30;
                

            //Act
            var result = calculator.Add(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, result);
            
        }

        [Test]
        public void Should_Be_Able_To_Subtract_Two_Numbers()
        {
            //Arrange
            var calculator = new Calculator();
            var number1 = 10;
            var number2 = 20;
            var expectedResult = -10;


            //Act
            var result = calculator.Subtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}
