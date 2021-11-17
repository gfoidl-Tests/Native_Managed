// (c) gfoidl, all rights reserved

using NUnit.Framework;

namespace Managed.Tests.MathTests;

[TestFixture]
public class Add
{
    [Test]
    public void Two_summands_given___correct_sum()
    {
        int a = 3;
        int b = 4;

        int actual = Math.Add(a, b);

        Assert.That(actual, Is.EqualTo(a + b));
    }
}
