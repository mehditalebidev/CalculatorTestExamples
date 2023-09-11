using System;
using System.Collections.Generic;
using CalculatorTestPractice.Data;
using Xunit;

namespace CalculatorTestPractice.Tests;

public class CalculatorTestsMemberData
{
    private readonly Calculator _calculator;

    public CalculatorTestsMemberData()
    {
        _calculator = new Calculator();
    }
    public static IEnumerable<object[]> AddTestData()
    {
        yield return new object[] { new List<double> { 5, 7 }, 12 };
        yield return new object[] { new List<double> { 5, -3 }, 2 };
        yield return new object[] { new List<double> { 1, 2, 3, 4, 5 }, 15 };
    }
    
    [Theory]
    [MemberData(nameof(AddTestData))]
    public void Add_ReturnsCorrectSum(List<double> input, double expected)
    {
        var result = _calculator.Add(input);
        Assert.Equal(expected, result);
    }
}