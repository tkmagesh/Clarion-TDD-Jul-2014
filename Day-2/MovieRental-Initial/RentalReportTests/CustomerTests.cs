using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RentalReport;

namespace RentalReportTests
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer customer;

        [TestFixtureSetUp]
        public void Setup()
        {
            customer = new Customer("Magesh");
            customer.AddRental(new Rental(new Movie("Kick", 1), 3));
            customer.AddRental(new Rental(new Movie("Home Alone", 2), 2));
            customer.AddRental(new Rental(new Movie("Transformers", 0), 2));
        }

        [Test]
        public void Should_Calculate_Total_Amount()
        {
            //Arrange
            var expectedTotalAmount = 12.5d;

            //Act
            var totalAmount = customer.GetTotalAmount();

            //Assert
            Assert.That(totalAmount, Is.EqualTo(expectedTotalAmount));

        }

        [Test]
        public void Should_Calculate_Total_FrequentRentor_Points()
        {
            //Arrange
            var expectedPoints = 4;

            //Act
            var totalAmount = customer.GetTotalFrequentRenterPoints();

            //Assert
            Assert.That(totalAmount, Is.EqualTo(expectedPoints));

        }


        [Test]
        public void Should_Generate_Reports()
        {
            var expected = "Rental Record for Magesh\n\tKick\t9\n\tHome Alone\t1.5\n\tTransformers\t2\nAmount owed is 12.5\nYou earned 4 frequent renter points";

            var customer = new Customer("Magesh");
            customer.AddRental(new Rental(new Movie("Kick", 1), 3));
            customer.AddRental(new Rental(new Movie("Home Alone", 2), 2));
            customer.AddRental(new Rental(new Movie("Transformers", 0), 2));
            var result = customer.Statement();
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
