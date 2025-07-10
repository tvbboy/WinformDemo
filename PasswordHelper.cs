using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecurityUtils
{
    /// <summary>
    /// 密码安全处理工具类
    /// 提供加密、哈希、验证等功能
    /// </summary>
    public static class PasswordHelper
    {
        // 默认加密参数
        private const int DefaultSaltSize = 16;
        private const int DefaultKeySize = 256;
        private const int DefaultIterations = 10000;

        #region 哈希方法

        /// <summary>
        /// 使用PBKDF2算法生成密码哈希
        /// </summary>
        /// <param name="password">原始密码</param>
        /// <param name="salt">盐值(输出参数)</param>
        /// <param name="iterations">迭代次数</param>
        /// <returns>Base64格式的哈希值</returns>
        public static string CreateHash(string password, out string salt, int iterations = DefaultIterations)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("密码不能为空");

            // 生成随机盐值
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] saltBytes = new byte[DefaultSaltSize];
                rng.GetBytes(saltBytes);
                salt = Convert.ToBase64String(saltBytes);
            }

            return CreateHash(password, salt, iterations);
        }

        /// <summary>
        /// 使用PBKDF2算法生成密码哈希
        /// </summary>
        /// <param name="password">原始密码</param>
        /// <param name="salt">盐值</param>
        /// <param name="iterations">迭代次数</param>
        /// <returns>Base64格式的哈希值</returns>
        public static string CreateHash(string password, string salt, int iterations = DefaultIterations)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("密码不能为空");

            if (string.IsNullOrWhiteSpace(salt))
                throw new ArgumentException("盐值不能为空");

            // 将密码和盐值转换为字节数组
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // 使用PBKDF2算法生成哈希
            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordBytes, saltBytes, iterations, HashAlgorithmName.SHA256))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32); // 256位
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// 验证密码与哈希是否匹配
        /// </summary>
        /// <param name="password">原始密码</param>
        /// <param name="salt">盐值</param>
        /// <param name="storedHash">存储的哈希值</param>
        /// <param name="iterations">迭代次数</param>
        /// <returns>是否匹配</returns>
        public static bool VerifyHash(string password, string salt, string storedHash, int iterations = DefaultIterations)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("密码不能为空");

            if (string.IsNullOrWhiteSpace(salt))
                throw new ArgumentException("盐值不能为空");

            if (string.IsNullOrWhiteSpace(storedHash))
                throw new ArgumentException("存储的哈希值不能为空");

            // 生成新哈希
            string newHash = CreateHash(password, salt, iterations);

            // 使用恒定时间比较防止时序攻击
            return CryptographicOperations.FixedTimeEquals(
                Encoding.UTF8.GetBytes(newHash),
                Encoding.UTF8.GetBytes(storedHash)
            );
        }

        #endregion

        #region 加密方法

        /// <summary>
        /// AES加密字符串
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <param name="key">加密密钥</param>
        /// <param name="iv">初始化向量(输出参数)</param>
        /// <returns>Base64格式的加密结果</returns>
        public static string Encrypt(string plainText, string key, out string iv)
        {
            if (string.IsNullOrWhiteSpace(plainText))
                throw new ArgumentException("明文不能为空");

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("密钥不能为空");

            // 生成密钥和IV
            byte[] keyBytes = DeriveKey(key, DefaultKeySize / 8);
            byte[] ivBytes;

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.GenerateIV();
                ivBytes = aes.IV;
                iv = Convert.ToBase64String(ivBytes);

                return Encrypt(plainText, key, ivBytes);
            }
        }

        /// <summary>
        /// AES加密字符串
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <param name="key">加密密钥</param>
        /// <param name="iv">初始化向量</param>
        /// <returns>Base64格式的加密结果</returns>
        public static string Encrypt(string plainText, string key, string iv)
        {
            if (string.IsNullOrWhiteSpace(plainText))
                throw new ArgumentException("明文不能为空");

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("密钥不能为空");

            if (string.IsNullOrWhiteSpace(iv))
                throw new ArgumentException("初始化向量不能为空");

            byte[] ivBytes = Convert.FromBase64String(iv);
            return Encrypt(plainText, key, ivBytes);
        }

        private static string Encrypt(string plainText, string key, byte[] ivBytes)
        {
            byte[] keyBytes = DeriveKey(key, DefaultKeySize / 8);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                        cs.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        /// <summary>
        /// AES解密字符串
        /// </summary>
        /// <param name="cipherText">Base64格式的密文</param>
        /// <param name="key">加密密钥</param>
        /// <param name="iv">初始化向量</param>
        /// <returns>解密后的明文</returns>
        public static string Decrypt(string cipherText, string key, string iv)
        {
            if (string.IsNullOrWhiteSpace(cipherText))
                throw new ArgumentException("密文不能为空");

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("密钥不能为空");

            if (string.IsNullOrWhiteSpace(iv))
                throw new ArgumentException("初始化向量不能为空");

            byte[] keyBytes = DeriveKey(key, DefaultKeySize / 8);
            byte[] ivBytes = Convert.FromBase64String(iv);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                using (MemoryStream ms = new MemoryStream(cipherBytes))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        #endregion

        #region 辅助方法

        /// <summary>
        /// 从密码派生密钥
        /// </summary>
        private static byte[] DeriveKey(string password, int keySize)
        {
            byte[] salt = Encoding.UTF8.GetBytes("SecureKeySalt");
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, DefaultIterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(keySize);
            }
        }

        /// <summary>
        /// 生成强随机密码
        /// </summary>
        /// <param name="length">密码长度</param>
        /// <param name="includeSpecialChars">是否包含特殊字符</param>
        /// <returns>随机密码</returns>
        public static string GenerateRandomPassword(int length = 16, bool includeSpecialChars = true)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*()_-+=[]{}|;:,.<>?";

            string validChars = upper + lower + digits;
            if (includeSpecialChars) validChars += special;

            StringBuilder password = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[4];

                while (password.Length < length)
                {
                    rng.GetBytes(randomBytes);
                    uint randomValue = BitConverter.ToUInt32(randomBytes, 0);
                    password.Append(validChars[(int)(randomValue % (uint)validChars.Length)]);
                }
            }
            return password.ToString();
        }

        #endregion
    }
}