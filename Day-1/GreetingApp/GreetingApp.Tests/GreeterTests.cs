using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GreetingApp.Tests
{
    /*public class FakeTimeServiceForMorning : ITimeService
    {
        public DateTime GetTime()
        {
            return new DateTime(2014,07,26,11,0,0);
        }
    }

    public class FakeTimeServiceForEvening : ITimeService
    {
        public DateTime GetTime()
        {
            return new DateTime(2014, 07, 26, 15, 0, 0);
        }
    }
*/
    [TestFixture]
    public class GreeterTests
    {
        [Test]
        public void Should_Greet_Good_Morning_Before_12()
        {
            //Arrange
            var mock = new Moq.Mock<ITimeService>();
            mock
                .Setup(ts => ts.GetTime())
                .Returns(() => new DateTime(2014, 7, 26, 10, 0, 0));

            var morningTimeService = mock.Object;
            var greeter = new Greeter(morningTimeService);
            var name = "Magesh";
            var expectedMsg = "Good Morning Magesh!";
            
            //Act
            var greetMsg = greeter.Greet(name);

            //Assert
            Assert.AreEqual(expectedMsg, greetMsg);
        }

        [Test]
        public void Should_Greet_Good_Afternoon_After_12()
        {
            //Arrange
            var mock = new Moq.Mock<ITimeService>();
            mock
                .Setup(ts => ts.GetTime())
                .Returns(() => new DateTime(2014, 7, 26, 15, 0, 0));

            var greeter = new Greeter(mock.Object);
            var name = "Magesh";
            var expectedMsg = "Good Afternoon Magesh!";

            //Act
            var greetMsg = greeter.Greet(name);

            //Assert
            Assert.AreEqual(expectedMsg, greetMsg);
        }

    }
}
