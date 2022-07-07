using Moq;
using NUnit.Framework;
using Shouldly;
using UnitTest_Moq_Example;

namespace MoqExample.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ping_Invoke_Something()
        {
            // Arrange
            var mock = new Mock<IFoo>();
            mock.Setup(x => x.DoSomething(It.IsAny<string>())).Returns(true);
            var service = new Service(mock.Object);

            // Act
            service.Ping();

            // Assert
            //mock.Verify(p => p.DoSomething("PING"), Times.Once()); // old way to do

            // using shouldy to verify 
            this.ShouldSatisfyAllConditions
            (
                () => mock.VerifyAll()
            );
        }
    }
}