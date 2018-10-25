using System.Collections;

namespace Calculator.Unit.Test
{
    public class TestCaseSource : IEnumerable
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
}
