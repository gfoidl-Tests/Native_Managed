using System;
using NUnit.Framework;

namespace Managed.Tests.MathTests
{
    [TestFixture]
    public class Sum
    {
        [Test]
        public void Empty_span___0()
        {
            ReadOnlySpan<int> data = ReadOnlySpan<int>.Empty;

            int actual = Math.Sum(data);

            Assert.AreEqual(0, actual);
        }
        //---------------------------------------------------------------------
        [Test]
        public void Well_known_data___correct_sum()
        {
            ReadOnlySpan<int> data = new int[] { 1, 2, 3 };

            int actual = Math.Sum(data);

            Assert.AreEqual(6, actual);
        }
    }
}
