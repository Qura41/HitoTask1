using HitoTaskArray1;

namespace UnitTest.Tests;
using static HitoTaskArray1.ArrayMethods;
using static HitoTaskArray1.IO;
using static HitoTaskArray1.IInputReader;
using Xunit;

public class ArrayTests
{
    [Fact]
    public void CopyArray_ValidInput_ReturnsCopiedArray()
    {
        int[,] originalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        var expectedArray = (int[,])originalArray.Clone();

        var copiedArray = ArrayMethods.CopyArray(originalArray);

        Assert.Equal(expectedArray, copiedArray);
    }
    
    [Fact]
    public void CreateArray_ValidInput_ReturnsArrayWithCorrectDimensions()
    {
        int linesCount = 3;
        int columnsCount = 4;

        var array = ArrayMethods.CreateArray(linesCount, columnsCount);

        Assert.Equal(linesCount, array.GetLength(0));
        Assert.Equal(columnsCount, array.GetLength(1));
    }
    
    [Fact]
    public void ReverseArray_ValidInput_ReturnsReversedArray()
    {
        int[,] originalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] expectedArray = { { 3, 2, 1 }, { 6, 5, 4 } };

        var reversedArray = ArrayMethods.ReverseArray(originalArray);

        Assert.Equal(expectedArray, reversedArray);
    }
}