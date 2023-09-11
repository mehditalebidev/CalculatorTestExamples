using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;

namespace CalculatorTestPractice;

public class Calculator
{
    public double Add(double addend1, double addend2)
    {
        return addend1 + addend2;
    }
    public double Add(List<double> numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException(nameof(numbers), "The input list cannot be null.");
        }
        return numbers.Sum();
    }
    #region others
    public double Subtract(double minuend, double subtrahend)
    {
        return minuend - subtrahend;
    }

    public double Multiply(double factor1, double factor2)
    {
        return factor1 * factor2;
    }    
    
    public double Multiply(List<double> numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException(nameof(numbers));
        }

        return numbers.Aggregate(1.0, (acc, number) => acc * number);
    }

    public double Divide(double dividend, double divisor)
    {
        if (Math.Abs(divisor) < double.Epsilon)
        {
            throw new DivideByZeroException();
        }

        return dividend / divisor;
    }

    public double Modulus(double number, double modulus)
    {
        if (Math.Abs(modulus) < double.Epsilon)
        {
            throw new DivideByZeroException();
        }

        return number % modulus;
    }
    
    #endregion
}