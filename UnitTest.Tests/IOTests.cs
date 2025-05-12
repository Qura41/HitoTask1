using HitoTaskArray1;

namespace UnitTest.Tests;
using static HitoTaskArray1.ArrayMethods;
using static HitoTaskArray1.IO;
using static HitoTaskArray1.IInputReader;
using Xunit;

public class IOTests
{
    public class TestInputReader : IInputReader
    {
        private readonly string[] _inputs;
        private int _currentIndex;

        public TestInputReader(string[] inputs)
        {
            _inputs = inputs;
            _currentIndex = 0;
        }

        public string ReadLine()
        {
            if (_currentIndex < _inputs.Length)
            {
                return _inputs[_currentIndex++];
            }
            return null; // Возвращаем null, если больше нет входных данных
        }
    }
    
    [Fact]
    public void Validation_ValidIntegerInput()
    {
        // Arrange
        var inputReader = new TestInputReader(new[] { "xyz", "1.5", "100" });

        // Act
        int result = IO.Validation(inputReader);

        // Assert
        Assert.Equal(100, result);
    }
    
    [Fact]
    public void LinesCount_ValidInput_SetsLines()
    {
        // Arrange
        var reader = new TestInputReader(new[] { "3" });

        // Act
        LinesCount(reader);

        // Assert
        Assert.Equal(3, Lines);
    }

    [Fact]
    public void ColumnsCount_ValidInput_SetsColumns()
    {
        // Arrange
        var reader = new TestInputReader(new[] { "4" });

        // Act
        ColumnsCount(reader);

        // Assert
        Assert.Equal(4, Columns);
    }
}