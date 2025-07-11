using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace myproject
{
    public static class APPConfigManager
    {
        private static readonly string ConfigPath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;

        /// <summary>
        /// 获取自定义配置节的值
        /// </summary>
        public static NameValueCollection GetCustomSection(string sectionName)
        {
            try
            {
                return (NameValueCollection)ConfigurationManager.GetSection(sectionName);
            }
            catch (Exception ex)
            {
                LogError($"读取配置节 '{sectionName}' 失败: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// 更新自定义配置节的值
        /// </summary>
        public static void UpdateCustomSection(string sectionName, NameValueCollection values)
        {
            try
            {
                // 加载配置文件
                XmlDocument doc = new XmlDocument();
                doc.Load(ConfigPath);

                // 获取配置节节点
                XmlNode sectionNode = GetOrCreateSectionNode(doc, sectionName);

                // 更新配置项
                foreach (string key in values.AllKeys)
                {
                    UpdateSettingNode(doc, sectionNode, key, values[key]);
                }

                // 保存更改
                doc.Save(ConfigPath);

                // 刷新配置
                ConfigurationManager.RefreshSection(sectionName);
            }
            catch (Exception ex)
            {
                LogError($"更新配置节 '{sectionName}' 失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 获取或创建配置节节点
        /// </summary>
        private static XmlNode GetOrCreateSectionNode(XmlDocument doc, string sectionName)
        {
            // 查找现有节点
            XmlNode sectionNode = doc.SelectSingleNode($"//{sectionName}");

            if (sectionNode == null)
            {
                // 创建新节点
                sectionNode = doc.CreateElement(sectionName);

                // 添加到根节点
                XmlNode configurationNode = doc.SelectSingleNode("//configuration");
                configurationNode.AppendChild(sectionNode);
            }

            return sectionNode;
        }

        /// <summary>
        /// 更新配置项节点
        /// </summary>
        private static void UpdateSettingNode(XmlDocument doc, XmlNode parentNode, string key, string value)
        {
            // 查找现有设置
            XmlNode settingNode = parentNode.SelectSingleNode($"add[@key='{key}']");

            if (settingNode == null)
            {
                // 创建新设置节点
                settingNode = doc.CreateElement("add");

                // 添加key属性
                XmlAttribute keyAttr = doc.CreateAttribute("key");
                keyAttr.Value = key;
                settingNode.Attributes.Append(keyAttr);

                // 添加value属性
                XmlAttribute valueAttr = doc.CreateAttribute("value");
                valueAttr.Value = value;
                settingNode.Attributes.Append(valueAttr);

                // 添加到父节点
                parentNode.AppendChild(settingNode);
            }
            else
            {
                // 更新现有设置
                XmlAttribute valueAttr = settingNode.Attributes["value"];
                if (valueAttr != null)
                {
                    valueAttr.Value = value;
                }
                else
                {
                    valueAttr = doc.CreateAttribute("value");
                    valueAttr.Value = value;
                    settingNode.Attributes.Append(valueAttr);
                }
            }
        }

        /// <summary>
        /// 安全加密字符串（使用 DPAPI）
        /// </summary>
        public static string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;

            try
            {
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = ProtectedData.Protect(
                    plainBytes,
                    null,
                    DataProtectionScope.CurrentUser);

                return Convert.ToBase64String(encryptedBytes);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 安全解密字符串（使用 DPAPI）
        /// </summary>
        public static string DecryptString(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) return string.Empty;

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(cipherText);
                byte[] plainBytes = ProtectedData.Unprotect(
                    encryptedBytes,
                    null,
                    DataProtectionScope.CurrentUser);

                return Encoding.UTF8.GetString(plainBytes);
            }
            catch
            {
                return string.Empty;
            }
        }

        private static void LogError(string message)
        {
            // 在实际应用中应记录到文件
            System.Diagnostics.Debug.WriteLine($"[ConfigManager] {DateTime.Now}: {message}");
        }
    }
}