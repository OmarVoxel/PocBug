using PocBugCop;
using System.Collections.Generic;
using Xunit;

namespace PocBugTest
{
    public class PocBugTest
    {
        public static IEnumerable<object[]> PocTestStaticMethod()
        {
            PocBug poc = new PocBug();
            poc.CreateDirectory();

            return new List<object[]>
            {
                new object[] { 1 },
            };
        }

        [Theory]
        [MemberData(nameof(PocTestStaticMethod))]
        public void PocTestMethod(int num)
        {
            Assert.Equal(1, num);
        }
    }
}
