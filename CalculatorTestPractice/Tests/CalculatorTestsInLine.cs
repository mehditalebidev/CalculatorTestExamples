using System;
using System.Collections.Generic;
using CalculatorTestPractice.Data;
using Xunit;

namespace CalculatorTestPractice.Tests;

public class CalculatorTestsInLine
{
    private readonly Calculator _calculator;

    public CalculatorTestsInLine()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(new double[] { 5, 7 }, 12)]
    [InlineData(new double[] { 5, -3 }, 2)]
    [InlineData(new double[] { 1, 2, 3, 4, 5 }, 15)]
    public void Add_ReturnsCorrectSum(double[] input, double expected)
    {
        var numbers = new List<double>(input);
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}