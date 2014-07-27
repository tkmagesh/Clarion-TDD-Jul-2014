using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RentalReport;

namespace RentalReportTests
{
    [TestFixture]
    public class RentalTests
    {
        private Rental childrensMovieRental;

        [TestFixtureSetUp]
        public void Setup()
        {
            childrensMovieRental = new Rental(new Movie("Home Alone", 2), 2);    
        }

        [Test]
        public void Amount_For_Childrens_Movie_Rented_for_2_days_Is_Calculated()
        {
            //Arrange
            var expectedAmount = 1.5;

            //Act
            var amount = childrensMovieRental.CalculateAmount();

            //Assert
            Assert.That(amount, Is.EqualTo(expectedAmount));
        }

    }
}
