using NUnit.Framework;

namespace Charix.WebUtility.Tests
{
    public class DeviceTests
    {
        [Test]
        public void IsMobileShouldReturnFalse()
        {
            Assert.IsFalse(Device.IsMobile);
        }
    }
}
