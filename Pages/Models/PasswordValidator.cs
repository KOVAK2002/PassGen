using System;

namespace PassGen.Models
{
    public static class PasswordValidator
    {
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Length <= 8)
                return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!password.Any(char.IsLower))
                return false;

            return true;
        }
    
     public static List<string> GeneratePasswords(int length, bool includeUpper, bool includeLower, int count)
        {
            List<string> passwords = new List<string>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string password = string.Empty;

                if (includeUpper)
                {
                    password += (char)random.Next('A', 'Z' + 1);
                }

                if (includeLower)
                {
                    password += (char)random.Next('a', 'z' + 1);
                }

                while (password.Length < length)
                {
                    char randomChar = (char)random.Next('A', 'z' + 1);
                    password += randomChar;
                }

                passwords.Add(password);
            }

            return passwords;
        }
    }
}
