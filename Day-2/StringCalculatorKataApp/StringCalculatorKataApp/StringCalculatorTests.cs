using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using StringCalculatorApp;

namespace StringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Should_Return_Zero_When_Added_An_Empty_String()
        {
            //Arrange
            var calculator = new StringCalculator();
            var input = string.Empty;
            var expectedResult = 0;

            //Act
            var result = calculator.Add(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Should_Return_The_Number_When_Added_The_Number_In_String_Format()
        {
            //Arrange
            var calculator = new StringCalculator();
            var input = "1";
            var expectedResult = 1;

            //Act
            var result = calculator.Add(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Should_Add_A_List_Of_Numbers_Seperated_By_Comma()
        {
            //Arrange
            var calculator = new StringCalculator();
            var input = "1,2,3";
            var expectedResult = 6;

            //Act
            var result = calculator.Add(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
