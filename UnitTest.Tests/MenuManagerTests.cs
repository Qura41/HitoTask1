using HitoTaskArray1;

namespace UnitTest.Tests;
using Xunit;

public class MenuManagerTests
{
    MenuManager menuManager = new MenuManager();
    
    // Arrange
    [Theory]
    [InlineData("123", true)]
    [InlineData("-123", false)]
    [InlineData("0", false)]
    [InlineData("abc", false)]
    [InlineData("12.34", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void isValid_ValidIntegerInput(string input, bool expected)
    {
        // Act
        var result = menuManager.isValid(input);

        // Assert
        Assert.Equal(expected, result);
    }
}