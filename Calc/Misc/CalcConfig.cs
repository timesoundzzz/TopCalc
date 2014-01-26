using System.Configuration;

namespace TopCalc.Misc
{
    public class CalcConfig : ConfigurationSection
    {
        public const string ConfigName = "App.config";
        public static string SectionName
        {
            get { return "CalcConfiguration"; }
        }

        [ConfigurationProperty("TopFilePath")]
        public string TopFilePath
        {
            get { return (string)this["TopFilePath"]; }
            set { this["TopFilePath"] = value; }
        }
    }
}
