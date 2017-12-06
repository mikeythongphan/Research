namespace vnyi.Utility.RES
{
    using Microsoft.Win32;
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.IO;
    using System.Xml;
    using System.Reflection;

    public class clsSysUtils
    {
        public const string DefaultConfigSection = "appSettings";

        #region GetConfig
        public static string GetConfig(string ConfigKey)
        {
            return GetConfig("appSettings", ConfigKey, "");
        }

        public static int GetConfig(string ConfigKey, int DefaultValue)
        {
            return GetConfig("appSettings", ConfigKey, DefaultValue);
        }

        public static string GetConfig(string ConfigSection, string ConfigKey)
        {
            return GetConfig(ConfigSection, ConfigKey, "");
        }

        public static int GetConfig(string ConfigSection, string ConfigKey, int DefaultValue)
        {
            string s = GetConfig(ConfigSection, ConfigKey, DefaultValue.ToString());
            try
            {
                return int.Parse(s);
            }
            catch
            {
                return DefaultValue;
            }
        }

        public static string GetConfig(string ConfigSection, string ConfigKey, string DefaultValue)
        {
            NameValueCollection configSection = GetConfigSection(ConfigSection);
            if ((configSection != null) && (configSection.Count != 0))
            {
                return configSection.Get(ConfigKey);
            }
            return DefaultValue;
        }

        public static NameValueCollection GetConfigSection(string ConfigSection)
        {
            return (NameValueCollection)ConfigurationSettings.GetConfig(ConfigSection);
        }

        #endregion

        #region SetConfig
        public static bool SetConfig(string ConfigKey, string Value)
        {
            return SetConfig("appSettings", ConfigKey, Value);
        }

        public static bool SetConfig(string ConfigSection, string ConfigKey, string Value)
        {
            NameValueCollection configSection = GetConfigSection(ConfigSection);
            if ((configSection != null) && (configSection.Count != 0))
            {
                try
                {
                    configSection.Set(ConfigKey, Value);
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
        #endregion

        #region MIME
        private static string GetMIMEDescription(string filename)
        {
            filename = Path.GetExtension(filename);
            if ((filename == null) || (filename == ""))
            {
                return "File";
            }
            string str = filename.Substring(1, filename.Length - 1).ToUpper() + " File";
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(filename, false);
            if (key != null)
            {
                object obj2 = key.GetValue("", "");
                if (obj2 != null)
                {
                    key = Registry.ClassesRoot.OpenSubKey(obj2.ToString(), false);
                    if (key != null)
                    {
                        obj2 = key.GetValue("", "");
                        if (obj2 != null)
                        {
                            str = obj2.ToString();
                        }
                    }
                }
            }
            return str;
        }

        public static string GetMIMEType(string FileName)
        {
            FileName = Path.GetExtension(FileName);
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(FileName, false);
            if (key != null)
            {
                return key.GetValue("Content Type", "application/octet-stream").ToString();
            }
            return "application/octet-stream";
        }

        #endregion

        #region read write XML config
        public static XmlDocument loadConfigDocument(string filepathXML)
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(filepathXML);
            }
            catch
            {
                //throw new Exception("No configuration file found.", e);
            }
            return doc;
        }

        public static string ReadSetting(string filepathXML, string key)
        {
            try
            {
                // load config document for current assembly
                XmlDocument doc = loadConfigDocument(filepathXML);

                if (doc == null) return string.Empty;
                // retrieve appSettings node
                XmlNode node = doc.SelectSingleNode("//Settings");

                if (node == null) return string.Empty;
                //throw new InvalidOperationException("Settings section not found in config file.");

                // select the 'add' element that contains the key
                XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    return elem.Attributes["value"].Value;
                }
                return string.Empty;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool WriteSetting(string filepathXML, string key, string value)
        {
            try
            {
                // load config document for current assembly
                XmlDocument doc = loadConfigDocument(filepathXML);
                if (doc == null) return false;
                // retrieve appSettings node

                XmlNode node = doc.SelectSingleNode("//Settings");

                if (node == null) return false;
                //throw new InvalidOperationException("Settings section not found in config file.");

                // select the 'add' element that contains the key
                XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    // add value for key
                    elem.SetAttribute("value", value);
                }
                else
                {
                    // key was not found so create the 'add' element 
                    // and set it's key/value attributes 
                    elem = doc.CreateElement("add");
                    elem.SetAttribute("key", key);
                    elem.SetAttribute("value", value);
                    node.AppendChild(elem);
                }
                doc.Save(filepathXML);
                return true;
            }
            catch { return false; }
        }
        public static void RemoveSetting(string filepathXML, string key)
        {
            try
            {
                // load config document for current assembly
                XmlDocument doc = loadConfigDocument(filepathXML);
                if (doc == null) return;
                // retrieve appSettings node
                XmlNode node = doc.SelectSingleNode("//Settings");

                if (node == null) return;
                //throw new InvalidOperationException("Settings section not found in config file.");
                else
                {
                    // remove 'add' element with coresponding key
                    node.RemoveChild(node.SelectSingleNode(string.Format("//add[@key='{0}']", key)));
                    doc.Save(filepathXML);
                }
            }
            catch
            {
                //throw new Exception(string.Format("The key {0} does not exist.", key), e);
            }
        }
        #endregion

        #region AutoStart With Window
        private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";
        public static string keyName = "QuickDecision";
        //public static string assemblyLocation = Assembly.GetExecutingAssembly().Location;  // Or the EXE path.

        /// <summary>
        /// Sets the autostart value for the assembly.
        /// </summary>
        /// <param name="keyName">Registry Key Name</param>
        /// <param name="assemblyLocation">Assembly location (e.g. Assembly.GetExecutingAssembly().Location)</param>
        public static bool SetAutoStart(string keyName, string assemblyLocation)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.CreateSubKey(RUN_LOCATION);
                key.SetValue(keyName, assemblyLocation);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Returns whether auto start is enabled.
        /// </summary>
        /// <param name="keyName">Registry Key Name</param>
        /// <param name="assemblyLocation">Assembly location (e.g. Assembly.GetExecutingAssembly().Location)</param>
        public static bool IsAutoStartEnabled(string keyName, string assemblyLocation)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(RUN_LOCATION);
                if (key == null)
                    return false;

                string value = (string)key.GetValue(keyName);
                if (value == null)
                    return false;

                return (value == assemblyLocation);
            }
            catch { return false; }
        }

        /// <summary>
        /// Unsets the autostart value for the assembly.
        /// </summary>
        /// <param name="keyName">Registry Key Name</param>
        private static bool UnSetAutoStart(string keyName)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.CreateSubKey(RUN_LOCATION);
                key.DeleteValue(keyName);
                return true;
            }
            catch { return false; }
        }

        public static bool UnSetAutoStart(string p_KeyName, string p_assemblyLocation)
        {
            try
            {
                // Unset Auto-start.
                if (IsAutoStartEnabled(p_KeyName, p_assemblyLocation))
                    if (UnSetAutoStart(p_KeyName))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
            catch { return false; }
        }

        #endregion

        #region Registry
        public static string ReadReg(RegistryKey baseRegistryKey, string subKey, string KeyName)
        {
            RegistryKey sk1 = baseRegistryKey.OpenSubKey(subKey);
            // If the RegistrySubKey doesn't exist -> (null)

            if (sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    // If the RegistryKey exists I get its value

                    // or null is returned.

                    return (string)sk1.GetValue(KeyName.ToUpper());
                }
                catch
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// To write into a registry key.
        /// input: KeyName (string) , Value (object)
        /// output: true or false 
        /// </summary>
        public static bool WriteReg(RegistryKey baseRegistryKey, string subKey, string KeyName, object Value)
        {
            try
            {
                // I have to use CreateSubKey 
                // (create or open it if already exits), 
                // 'cause OpenSubKey open a subKey as read-only
                RegistryKey sk1 = baseRegistryKey.CreateSubKey(subKey);
                // Save the value
                sk1.SetValue(KeyName.ToUpper(), Value);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// To delete a registry key.
        /// input: KeyName (string)
        /// output: true or false 
        /// </summary>
        public static bool DeleteKeyReg(RegistryKey baseRegistryKey, string subKey, string KeyName)
        {
            try
            {
                RegistryKey sk1 = baseRegistryKey.CreateSubKey(subKey);
                // If the RegistrySubKey doesn't exists -> (true)
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// To delete a sub key and any child.
        /// input: void
        /// output: true or false 
        /// </summary>
        public static bool DeleteSubKeyTreeReg(RegistryKey baseRegistryKey, string subKey)
        {
            try
            {
                RegistryKey sk1 = baseRegistryKey.OpenSubKey(subKey);
                // If the RegistryKey exists, I delete it
                if (sk1 != null)
                    baseRegistryKey.DeleteSubKeyTree(subKey);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retrive the count of subkeys at the current key.
        /// input: void
        /// output: number of subkeys
        /// </summary>
        public static int SubKeyCount(RegistryKey baseRegistryKey, string subKey)
        {
            try
            {
                RegistryKey sk1 = baseRegistryKey.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Retrive the count of values in the key.
        /// input: void
        /// output: number of keys
        /// </summary>
        public static int ValueCount(RegistryKey baseRegistryKey, string subKey)
        {
            try
            {
                RegistryKey sk1 = baseRegistryKey.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.ValueCount;
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }

        #endregion

    }
}

