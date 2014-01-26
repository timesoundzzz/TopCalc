using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TopCalc.Calc;
using TopCalc.UI;

namespace TopCalc.Fix
{
    public class FixHelper
    {
        public static FixResult MasterSlaveFix(ParseResult parseResult)
        {
            FixResult fixedResult = null;
            try
            {
                if (parseResult.TopList.Count > 0)
                {
                    Dictionary<string, List<int>> names =
                        CalcParser.GetAllAlbumNamesWithGlobalLocation(parseResult.TopList);
                    if (names.Count > 0)
                    {
                        var masterSlave = new MasterSlave();
                        foreach (var name in names.OrderBy(r => r.Key))
                        {
                            var albumName = new Album(name.Key, name.Value);
                            masterSlave.AlbumNames.Add(albumName);
                        }
                        var frmMasterSlave = new FrmMasterSlave(masterSlave, parseResult.TotalStringList);
                        frmMasterSlave.ShowDialog();
                        fixedResult = frmMasterSlave.Result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fixedResult;
        }

        public static FixResult NumerationFix(ParseResult parseResult)
        {
            FixResult fixResult = new FixResult();
            try
            {
                fixResult.In.AddRange(parseResult.TotalStringList);
                List<string> changedList = new List<string>();
                string secondString = String.Empty;
                for (int i = 0; i < fixResult.In.Count; i++)
                {
                    string inString = fixResult.In[i];
                    string outString = inString.TrimStart();
                    bool isLastString = i == fixResult.In.Count - 1;
                    if (!isLastString)
                    {
                        secondString = fixResult.In[i + 1].TrimStart();
                    }
                    string fixedPntString = GetFixedNullPntString(outString, secondString, isLastString);
                    string trimmedString = GetInnerTrimmedString(fixedPntString);
                    fixResult.Out.Add(trimmedString);
                    if (trimmedString != inString)
                    {
                        changedList.Add(trimmedString);
                    }
                }
                MessageBox.Show(@"Обработка завершена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fixResult;
        }

        private static string GetFixedNullPntString(string topString, string secondString, bool isLastStr)
        {
            string fixedString = topString.Trim();
            var r = new Regex(@"\s+");

            fixedString = r.Replace(fixedString, @" ");

            if (fixedString.Length > 3)
            {
                if (Char.IsDigit(fixedString[0]))
                {
                    if (fixedString[0] != '2' && fixedString[0] != '1')
                    {
                        if (fixedString[0] != '0')
                        {
                            fixedString = "0" + fixedString;
                        }
                    }
                    else
                    {
                        if (!Char.IsDigit(fixedString[1]))
                        {
                            string secStr = secondString.Trim();
                            if (isLastStr || (secStr.Length > 3 && Char.IsDigit(secStr[0])))
                            {
                                fixedString = "0" + fixedString;
                            }
                        }
                    }
                }
                if (Char.IsDigit(fixedString[0]) && Char.IsDigit(fixedString[1]))
                {
                    if (fixedString[2] == '.')
                    {
                    }
                    else if (fixedString[2] == ' ' || fixedString[2] == ')' || fixedString[2] == ']')
                    {
                        fixedString = fixedString.Substring(0, 2) + '.' +
                                      fixedString.Substring(3, fixedString.Length - 3);
                    }
                }
            }
            return fixedString;
        }

        private static string GetInnerTrimmedString(string inString)
        {
            string outString = inString;
            bool isValitTopString = CalcParser.IsValidVote(outString);
            if (isValitTopString)
            {
                outString = outString.Substring(0, 3) + " " + outString.Substring(3, outString.Length - 3).Trim();
            }
            return outString;
        }
    }
}