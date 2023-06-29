using System.Runtime.InteropServices;

namespace Charix.WebUtility
{
    public static class Device
    {
        public static bool IsMobile => GetDeviceIsMobile();

        [DllImport("__Internal")]
        private static extern bool GetDeviceIsMobile();
    }
}
