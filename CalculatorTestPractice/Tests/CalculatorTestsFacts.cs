using System;
using System.Collections.Generic;
using CalculatorTestPractice.Data;
using Xunit;

namespace CalculatorTestPractice.Tests;

public class CalculatorTestsFacts
{
    private readonly Calculator _calculator;

    public CalculatorTestsFacts()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_WithTwoPositiveNumbers_ReturnsCorrectSum()
    {
        var numbers = new List<double> { 5, 7 };

        var result = _calculator.Add(numbers);

        Assert.Equal(12, result);
    }

    [Fact]
    public void Add_WithPositiveAndNegativeNumbers_ReturnsCorrectSum()
    {
        var numbers = new List<double> { 5, -3 };

        var result = _calculator.Add(numbers);

        Assert.Equal(2, result);
    }
}