using NUnit.Framework;

namespace Charix.WebUtility.Tests
{
    public class WebApplicationTests
    {
        [Test]
        public void InBackgroundShouldReturnFalse()
        {
            Assert.IsFalse(WebApplication.InBackground);
        }
    }
}
