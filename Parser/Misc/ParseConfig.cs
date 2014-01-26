using System;
using System.Configuration;
using System.Windows.Forms;
using TopHtmlParser.Common;

namespace TopHtmlParser.Misc
{
    public class ParseConfig : ConfigurationSection
    {
        public const string ConfigName = "App.config";

        public static string SectionName
        {
            get { return "ParseConfiguration"; }
        }

        [ConfigurationProperty("OnlineSource")]
        public string OnlineSource
        {
            get { return (string) this["OnlineSource"]; }
            set { this["OnlineSource"] = value; }
        }

        [ConfigurationProperty("SourceKind")]
        public TopSource SourceKind
        {
            get
            {
                TopSource topSource = TopSource.Alterside2012;
                try
                {
                    topSource = (TopSource) Enum.Parse(typeof (TopSource), (string) this["SourceKind"]);
                }
                catch (Exception)
                {
                }
                return topSource;
            }
            set { this["SourceKind"] = value.ToString(); }
        }

        [ConfigurationProperty("IsCheckUserRegDate")]
        public bool IsCheckUserRegDate
        {
            get
            {
                bool isCheck = false;
                try
                {
                    isCheck = (bool) this["IsCheckUserRegDate"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return isCheck;
            }
            set { this["IsCheckUserRegDate"] = value; }
        }

        [ConfigurationProperty("UserRegDateForCheck")]
        public DateTime UserRegDateForCheck
        {
            get
            {
                DateTime dateTimeForCheck = DateTime.Now;
                try
                {
                    dateTimeForCheck = DateTime.ParseExact((string)this["UserRegDateForCheck"], "dd.MM.yyyy", null); 
                }
                catch (Exception)
                {
                }
                return dateTimeForCheck;
            }
            set { this["UserRegDateForCheck"] = value.ToString("dd.MM.yyyy"); }
        }

        [ConfigurationProperty("IsCheckDoubleTops")]
        public bool IsCheckDoubleTops
        {
            get
            {
                bool isCheck = false;
                try
                {
                    isCheck = (bool) this["IsCheckDoubleTops"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return isCheck;
            }
            set { this["IsCheckDoubleTops"] = value; }
        }
    }
}