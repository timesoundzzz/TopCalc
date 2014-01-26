using System;
using System.Configuration;
using System.Windows.Forms;

namespace TopHtmlParser.Misc
{
    internal class ConfigHelp
    {
        public static ParseConfig GetConfig()
        {
            ParseConfig parseConfig = null;
            try
            {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = ParseConfig.ConfigName
                };
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                    ConfigurationUserLevel
                        .None);
                try
                {
                    parseConfig = configuration.Sections.Get(ParseConfig.SectionName) as ParseConfig;
                }
                catch (Exception)
                {
                    parseConfig = null;
                    configuration.Sections.Remove(ParseConfig.SectionName);
                }
                if (parseConfig == null)
                {
                    configuration.Sections.Add(ParseConfig.SectionName, new ParseConfig());
                    configuration.Save();
                    parseConfig = configuration.Sections.Get(ParseConfig.SectionName) as ParseConfig;
                }
                if (parseConfig == null)
                {
                    parseConfig = new ParseConfig();
                    throw new Exception("Ошибка в методе GetConfig");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return parseConfig;
        }
    }
}