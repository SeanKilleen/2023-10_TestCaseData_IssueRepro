using System.Collections;

namespace TestCaseSourceStuff;

public class Tests
{
    [TestFixture]
    public class MyTests
    {
        [TestCaseSource(typeof(MyDataClass), nameof(MyDataClass.TestCases))]
        public int DivideTest(int n, int d)
        {
            return n / d;
        }
    }

    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(12, 3).SetName("12 divided by 3").Returns(4);
                yield return new TestCaseData(12, 2).SetName("12/2").Returns(6);
                yield return new TestCaseData(12, 4).SetName("12 divided by (4)").Returns(3);
            }
        }
    }
}