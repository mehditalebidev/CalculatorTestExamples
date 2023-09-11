using System;
using System.Collections.Generic;
using CalculatorTestPractice.Data;
using Xunit;

namespace CalculatorTestPractice.Tests;

public class CalculatorTestsClassData
{
    private readonly Calculator _calculator;

    public CalculatorTestsClassData()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [ClassData(typeof(AddTestData))]
    public void Add_ReturnsCorrectSum(List<double> input, double expected)
    {
        var result = _calculator.Add(input);
        Assert.Equal(expected, result);
    }
}