using System;
using System.Configuration;
using System.Windows.Forms;

namespace TopCalc.Misc
{
    internal class ConfigHelp
    {
        public static CalcConfig GetConfig()
        {
            CalcConfig calcConfig = null;
            try
            {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = CalcConfig.ConfigName
                };
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                    ConfigurationUserLevel
                        .None);
                try
                {
                    calcConfig = configuration.Sections.Get(CalcConfig.SectionName) as CalcConfig;
                }
                catch (Exception)
                {
                    calcConfig = null;
                    configuration.Sections.Remove(CalcConfig.SectionName);
                }
                if (calcConfig == null)
                {
                    configuration.Sections.Add(CalcConfig.SectionName, new CalcConfig());
                    configuration.Save();
                    calcConfig = configuration.Sections.Get(CalcConfig.SectionName) as CalcConfig;
                }
                if (calcConfig == null)
                {
                    calcConfig = new CalcConfig();
                    throw new Exception("Ошибка в методе GetConfig");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return calcConfig;
        }
    }
}