using NUnit.Framework;

namespace Managed.Tests.MathTests
{
    [TestFixture]
    public class Add
    {
        [Test]
        public void Two_summands_given___correct_sum()
        {
            const int a = 3;
            const int b = 4;

            int actual = Math.Add(a, b);

            Assert.AreEqual(a + b, actual);
        }
    }
}
