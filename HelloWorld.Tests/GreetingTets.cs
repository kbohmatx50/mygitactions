
using HelloWorld;
using Xunit;

namespace HelloWorld.Tests;

public class GreetingTests
{
    [Fact]
    public void GetMessage_ReturnsHelloWorld()
    {
        // Arrange
        Greeting greeting = new Greeting();

        // Act
        string result = greeting.GetMessage();

        // Assert
        Assert.Equal("Hello World!", result);
    }
}
