using System;
using System.Linq;

namespace Vaultrix.Helpers {
    public static class PasswordStrength {
        public static bool ContainsUppercaseLetter(string password) {
            return password.Any(char.IsUpper);
        }

        public static bool ContainsDigit(string password) {
            return password.Any(char.IsDigit);
        }

        public static bool ContainsSpecialCharacter(string password) {
            return password.Any(character => !char.IsLetterOrDigit(character));
        }

        public static int EvaluatePasswordStrength(string password) {
            int strengthScore = 0;

            if (ContainsUppercaseLetter(password))
                strengthScore += 20;

            if (ContainsDigit(password))
                strengthScore += 20;

            if (password.Length >= 8)
                strengthScore += 20;
            else
                strengthScore -= 20;

            if (ContainsSpecialCharacter(password))
                strengthScore += 20;

            if (password.Length >= 20)
                strengthScore += 20;

            return Math.Max(strengthScore, 0); // Make sure the score is positive
        }

        public static string GetPasswordStrengthDescription(int strengthScore) {
            switch (strengthScore) {
                case 20:
                    return "Really Weak";
                case 40:
                    return "Weak";
                case 60:
                    return "Medium";
                case 80:
                    return "Strong";
                case 100:
                    return "Really Strong";
                default:
                    return "Extremely Weak";
            }
        }
    }
}
