using System.Collections;

namespace Calculator.Unit.Test
{
    public class TestCaseSourceAddition : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] {3, 3, 6};
            yield return new[] {-3, -3, -6};
            yield return new[] {3, -3, 0};
            yield return new[] {-3, 0, -3};
            yield return new[] {0, 0, 0};
        }
    }


    public class TestCaseSourceSubtraction : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] {1, 0, 1};
            yield return new[] {-3, -3, 0};
            yield return new[] {3, -3, 6};
            yield return new[] {0, 1, -1};
        }
    }

    public class TestCaseSourceMultiply : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] { 2, 2, 4 };
            yield return new[] { -4, -4, 16 };
            yield return new[] { -3, 9, -27 };
            yield return new[] { 10, 0, 0 };
        }
    }

    public class TestCaseSourcePower : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] { 2, 2, 4 };
            yield return new[] { -4, -4, 16 };
            yield return new[] { -3, 3, -9 };
            yield return new[] { 10, 0, 0 };
            yield return new[] { 10, 2, 20 };
            yield return new[] { 10, 0, 0 };
            yield return new[] { 10, 0.5, 5 };
        }
    }
}
