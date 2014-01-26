using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using TopCalc.Calc;

namespace TopCalc.Out
{
    public static class SaveHelper
    {
        public static void SaveStrings(List<string> text, string fileName)
        {
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                FileName = fileName,
                AddExtension = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                using (var writer = new StreamWriter(fileName, false))
                {
                    foreach (var str in text)
                    {
                        writer.WriteLine(str);
                    }
                }
            }
        }

        private static string GetXmlFileName(string fileName)
        {
            string xmlFileName = string.Empty;
            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = @"xml files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                FileName = fileName,
                AddExtension = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlFileName = saveFileDialog1.FileName;
            }
            return xmlFileName;
        }

        private static void SaveToXml(CalcResult calcResult, ParseResult parseResult, string fileName)
        {
            var nfi = new NumberFormatInfo();
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(fileName, System.Text.Encoding.UTF8)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4
                };
                writer.WriteStartDocument();
                writer.WriteStartElement("Root");
                writer.WriteStartElement("TopWithVotes");
                int i = 0;
                foreach (KeyValuePair<Top, int> topPair in calcResult.SumMap.OrderByDescending(r => r.Value))
                {
                    Top top = topPair.Key;
                    writer.WriteStartElement("Album");
                    i++;
                    writer.WriteAttributeString("TopPlace", i.ToString(nfi));
                    writer.WriteAttributeString("Name", top.Name);
                    writer.WriteAttributeString("Sum", topPair.Value.ToString(nfi));
                    writer.WriteStartElement("Votes");
                    foreach (Vote vote in top.Votes.OrderBy(r => r.Place))
                    {
                        if (vote.State == VoteState.Normal)
                        {
                            string strPlace = CalcParser.GetStringPlace(vote.Place);
                            writer.WriteStartElement("Vote");
                            writer.WriteAttributeString("Post", vote.PostNoStr);
                            writer.WriteAttributeString("Place", strPlace);
                            writer.WriteAttributeString("AlbumName", vote.AlbumName);
                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("SortedListOfAlbumNames");
                Dictionary<string, List<int>> allNamesWithLocation =
                    CalcParser.GetAllAlbumNamesWithGlobalLocation(parseResult.TopList);
                List<string> allNames = allNamesWithLocation.Keys.ToList();

                var literNameMap = new Dictionary<string, List<string>>();
                string currentStart = string.Empty;
                var currentPair = new KeyValuePair<string, List<string>>();
                foreach (var allName in allNames.OrderBy(r => r))
                {
                    if (currentStart == string.Empty)
                    {
                        currentStart = allName[0].ToString(nfi);
                        currentPair = new KeyValuePair<string, List<string>>(currentStart, new List<string>());
                        literNameMap.Add(currentPair.Key, currentPair.Value);
                    }
                    if (currentStart == allName[0].ToString(nfi))
                    {
                        currentPair.Value.Add(allName);
                    }
                    else
                    {
                        currentStart = allName[0].ToString(nfi);
                        currentPair = new KeyValuePair<string, List<string>>(currentStart, new List<string>());
                        currentPair.Value.Add(allName);
                        literNameMap.Add(currentPair.Key, currentPair.Value);
                    }
                }

                foreach (var liter in literNameMap)
                {
                    writer.WriteStartElement("Liter");
                    writer.WriteAttributeString("LiterName", liter.Key);
                    writer.WriteStartElement("AlbumNames");
                    foreach (string albumName in liter.Value)
                    {
                        writer.WriteStartElement("Album");
                        writer.WriteAttributeString("Name", albumName);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("SimpleTopList");
                i = 0;
                foreach (KeyValuePair<Top, int> topPair in calcResult.SumMap.OrderByDescending(r => r.Value))
                {
                    Top top = topPair.Key;
                    i++;
                    writer.WriteStartElement("AlbumPlace");
                    writer.WriteAttributeString("Place", i.ToString(nfi));
                    writer.WriteAttributeString("AlbumName", top.Votes.First().AlbumName);
                    writer.WriteAttributeString("Sum", topPair.Value.ToString(nfi));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Ошибка: " + ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static void SaveAsXml(CalcResult calcResult, ParseResult parseResult, string fileName)
        {
            string xmlFileName = GetXmlFileName(fileName);
            if (!string.IsNullOrEmpty(xmlFileName))
            {
                SaveToXml(calcResult, parseResult, xmlFileName);
            }
        }
    }
}