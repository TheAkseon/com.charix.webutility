using NUnit.Framework;

namespace Charix.WebUtility.Tests
{
    public class AdBlockTests
    {
        [Test]
        public void AdBlockEnabledShouldNotThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                UnityEngine.Debug.Log($"{nameof(AdBlock)}.{nameof(AdBlock.Enabled)} = {AdBlock.Enabled}");
            });
        }
    }
}
