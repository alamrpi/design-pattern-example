using Moq;
using Xunit;

namespace design_patterns.Creational.SingletonDesignPattern
{
    public class SingletonTests
    {
        [Fact]
        public void TestDoSomethingMethod()
        {
            //Arrange
            var mockSingleton = new Mock<ISingleton>();
            mockSingleton.Setup(s => s.DoSomething()).Returns("Test");

            //Act
            string result = mockSingleton.Object.DoSomething();

            // assert the result
            Assert.Equal("Test", result);
        }
    }
}
