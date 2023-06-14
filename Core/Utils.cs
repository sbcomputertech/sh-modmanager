using System.Diagnostics;

namespace CWMM2.Core
{
    internal static class Utils
    {
        public static void OpenLink(string? uri)
        {
            if(string.IsNullOrEmpty(uri)) return;
            var psi = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            Process.Start(psi);
        }
    }
}
