using System.Collections;
using System.Collections.Generic;

namespace CalculatorTestPractice.Data;

public class AddTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new List<double> { 5, 7 }, 12 };
        yield return new object[] { new List<double> { 5, -3 }, 2 };
        yield return new object[] { new List<double> { 1, 2, 3, 4, 5 }, 15 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}