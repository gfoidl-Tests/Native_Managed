// (c) gfoidl, all rights reserved

using NUnit.Framework;

namespace Managed.Tests.MathTests
{
    [TestFixture]
    public class MetaInfos
    {
        [Test]
        public void GetNativeVersion___OK()
        {
            string actual = Math.GetNativeVersion();

            Assert.That(actual, Is.EqualTo("0.1.0"));
        }
        //---------------------------------------------------------------------
        [Test]
        public void GetNativeBuildConfig___OK()
        {
            string actual = Math.GetNativeBuildConfig();

            Assert.That(actual, Is.EqualTo("Release"));
        }
    }
}
