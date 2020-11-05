using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConfigurationApp
{
    public class Configuration
    {
        public static class ConfigurationManager { }
        public static void ReadAllSettings()
        {
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public static void ReadSetting(string key)
        {
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public static String CheckUser(string key, string value)
        {
            String allkey = "";
            //Boolean exists = false;
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                allkey = appSettings[key];

                if (allkey == null) {
                    allkey = "";
                }
                


                //exists = allkey.Contains(value);
                return allkey;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return allkey;
            }
        }

   

        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                System.Configuration.ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        public static void DeleteAppSettings(string key)
        {
            try
            {
                var configFile = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] != null)
                {
                    settings.Remove(key);
                }
                else
                {
                    
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                System.Configuration.ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
