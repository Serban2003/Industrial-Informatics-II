namespace ActivitiesWebApplication
{
    using System;
    using System.Security.Cryptography;

    public static class PasswordHasher
    {
        // Hash a password with PBKDF2, returning a base64‑encoded salt+hash
        public static String Hash(String password)
        {
            // 1) Create a 16‑byte salt
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(salt);

            // 2) Derive a 32‑byte subkey (hash) using 100k iterations of SHA‑256
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                // 3) Combine salt+hash and return as Base64
                byte[] hashBytes = new byte[16 + 32];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 32);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Verify an incoming password against the stored base64 salt+hash
        public static bool Verify(String password, String storedHash)
        {
            // 1) Decode the base64
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // 2) Re‑derive the hash on the incoming password
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                // 3) Compare byte by byte
                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                }
            }
            return true;
        }
    }

}