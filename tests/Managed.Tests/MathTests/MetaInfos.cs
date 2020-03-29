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

            Assert.AreEqual("0.1.0", actual);
        }
        //---------------------------------------------------------------------
        [Test]
        public void GetNativeBuildConfig___OK()
        {
            string actual = Math.GetNativeBuildConfig();

            Assert.AreEqual("Release", actual);
        }
    }
}
