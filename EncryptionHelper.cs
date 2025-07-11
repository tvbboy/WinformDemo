using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SecurityUtils
{
    public static class EncryptionHelper
    {
        // 从机器密钥派生加密密钥
        private static byte[] GetEncryptionKey()
        {
            // 使用固定盐值 + 机器特定信息创建密钥
            string machineSpecific = Environment.MachineName + Environment.UserName;
            using (var sha256 = SHA256.Create())
            {
                byte[] salt = Encoding.UTF8.GetBytes("SecureAutoLoginSalt");
                byte[] machineBytes = Encoding.UTF8.GetBytes(machineSpecific);

                byte[] combined = new byte[salt.Length + machineBytes.Length];
                Buffer.BlockCopy(salt, 0, combined, 0, salt.Length);
                Buffer.BlockCopy(machineBytes, 0, combined, salt.Length, machineBytes.Length);

                return sha256.ComputeHash(combined);
            }
        }

        // 加密字符串
        public static string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;

            using (Aes aes = Aes.Create())
            {
                aes.Key = GetEncryptionKey();
                aes.IV = new byte[16]; // 固定IV，因为密钥是机器特定的

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var ms = new System.IO.MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        cs.Write(plainBytes, 0, plainBytes.Length);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        // 解密字符串
        public static string DecryptString(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) return string.Empty;

            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = GetEncryptionKey();
                    aes.IV = new byte[16]; // 固定IV

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    byte[] cipherBytes = Convert.FromBase64String(cipherText);

                    using (var ms = new System.IO.MemoryStream(cipherBytes))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var reader = new System.IO.StreamReader(cs))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch
            {
                // 解密失败（可能是密钥变化或数据损坏）
                return string.Empty;
            }
        }
    }
}
