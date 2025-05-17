using HitoTaskArray1;

namespace UnitTest.Tests;
using Xunit;

public class ArrayTests
{
    ArrayMethods arrayMethods = new ArrayMethods();
    
    [Fact]
    public void CopyArray_ValidInput_ReturnsCopiedArray()
    {
        // Arrange
        int[,] originalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        var expectedArray = (int[,])originalArray.Clone();

        // Act
        var copiedArray = arrayMethods.CopyArray(originalArray);

        // Assert
        Assert.Equal(expectedArray, copiedArray);
    }
    
    [Fact]
    public void CreateArray_ValidInput_ReturnsArrayWithCorrectDimensions()
    {
        // Arrange
        int linesCount = 3;
        int columnsCount = 4;

        // Act
        var array = arrayMethods.CreateArray(linesCount, columnsCount);

        // Assert
        Assert.Equal(linesCount, array.GetLength(0));
        Assert.Equal(columnsCount, array.GetLength(1));
    }
    
    [Fact]
    public void ReverseArray_ValidInput_ReturnsReversedArray()
    {
        // Arrange
        int[,] originalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] expectedArray = { { 3, 2, 1 }, { 6, 5, 4 } };

        // Act
        var reversedArray = arrayMethods.ReverseArray(originalArray);

        // Assert
        Assert.Equal(expectedArray, reversedArray);
    }
}