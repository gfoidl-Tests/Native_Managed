// (c) gfoidl, all rights reserved

using System;
using NUnit.Framework;

namespace Managed.Tests.MathTests;

[TestFixture]
public class Sum
{
    [Test]
    public void Empty_span___0()
    {
        ReadOnlySpan<int> data = ReadOnlySpan<int>.Empty;

        int actual = Math.Sum(data);

        Assert.That(actual, Is.EqualTo(0));
    }
    //---------------------------------------------------------------------------------------------
    [Test]
    public void Well_known_data___correct_sum()
    {
        ReadOnlySpan<int> data = new int[] { 1, 2, 3 };

        int actual = Math.Sum(data);

        Assert.That(actual, Is.EqualTo(6));
    }
}
