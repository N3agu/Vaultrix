using System;
using System.Linq;

namespace Vaultrix.Helpers {
    public class Utils {
        public const string PasswordReplace = "●●●●●●●●";
        public static bool IsValidUrl(string url) {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult))
                if (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps)
                    return uriResult.Host.Contains('.') && uriResult.Host.Split('.').Last().Length >= 2;

            return false;
        }
    }
}
