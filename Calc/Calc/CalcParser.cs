using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopCalc.Calc
{
    public class CalcParser
    {
        public Settings CalcSettings { get; private set; }
        public List<string> ParseSource { get; private set; }
        public ParseResult ParseOut { get; private set; }
        public CalcResult CalcOut { get; private set; }

        public CalcParser(Settings calcSettings)
        {
            CalcSettings = calcSettings;
            ParseSource = GetTopFileStrings(CalcSettings.TopFileName);
            Recalc();
        }

        private List<string> GetTopFileStrings(string fileName)
        {
            List<string> strings = new List<string>();
            using (var file = new StreamReader(fileName, Encoding.UTF8))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    line = line.Replace("–", "-");
                    line = line.Replace("  -", " -");
                    line = line.Replace("-  ", "- ");
                    line = line.Trim();
                    strings.Add(line);
                }
            }
            return strings;
        }

        private static CalcResult GetCalcResult(ParseResult parseResult)
        {
            CalcResult calcResult = new CalcResult(parseResult.TopList);
            FillTxtOutByAlbumFullStats(calcResult.CheckPostTxtOut, parseResult, calcResult);
            FillTxtOutByAlbumNameSequence(calcResult.CheckNameTxtOut, parseResult);
            FillTxtOutBySimpleTopList(calcResult.ResultTxtOut, calcResult);
            return calcResult;
        }

        private static void FillTxtOutBySimpleTopList(List<string> txtOut, CalcResult calcResult)
        {
            txtOut.Add("Топ альбомов:");
            txtOut.Add("");
            int i = 0;
            foreach (KeyValuePair<Top, int> sumPair in calcResult.SumMap.OrderByDescending(r => r.Value))
            {
                i++;
                Top top = sumPair.Key;
                txtOut.Add(i + ". " + top.Votes.First().AlbumName + " (" + sumPair.Value + ")");
            }
            txtOut.Add("");
        }

        private static void FillTxtOutByAlbumNameSequence(List<string> txtOut, ParseResult parseResult)
        {
            txtOut.Add("Упорядоченный список наименований:");
            txtOut.Add("");
            Dictionary<string, List<int>> allNamesWithLocation = GetAllAlbumNamesWithGlobalLocation(parseResult.TopList);
            List<string> allNames = allNamesWithLocation.Keys.ToList();
            string currentStart = string.Empty;
            foreach (var allName in allNames.OrderBy(r => r))
            {
                if (currentStart == string.Empty)
                {
                    currentStart = allName[0].ToString(CultureInfo.InvariantCulture);
                    txtOut.Add(currentStart);
                }
                if (currentStart == allName[0].ToString(CultureInfo.InvariantCulture))
                {
                    txtOut.Add("   " + allName);
                }
                else
                {
                    currentStart = allName[0].ToString(CultureInfo.InvariantCulture);
                    txtOut.Add(currentStart);
                    txtOut.Add("   " + allName);
                }
            }
        }

        private static void FillTxtOutByAlbumFullStats(List<string> txtOut, ParseResult parseResult,
            CalcResult calcResult)
        {
            txtOut.Add("Полные данные расчетов:");
            txtOut.Add("");
            int i = 0;
            int maxPostCodeLength = GetMaxPostCodeLength(parseResult.TopList);
            foreach (KeyValuePair<Top, int> sumPair in calcResult.SumMap.OrderByDescending(r => r.Value))
            {
                i++;
                Top top = sumPair.Key;
                txtOut.Add("Album №" + i + ": " + top.Name);

                foreach (Vote vote in top.Votes.OrderBy(r => r.Place))
                {
                    if (vote.State == VoteState.Normal)
                    {
                        string strPlace = GetStringPlace(vote.Place);
                        string postCode = GetPostName(vote.PostNoStr, maxPostCodeLength);
                        txtOut.Add(strPlace + vote.AlbumName + postCode);
                    }
                }
                txtOut.Add("Sum: " + sumPair.Value);
                txtOut.Add("*********************************");
                txtOut.Add("");
            }
        }

        public void Recalc()
        {
            try
            {
                ParseOut = ParseTops(CalcSettings, ParseSource);
                CalcOut = GetCalcResult(ParseOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static List<string> GetInvalidVoteStrings(IEnumerable<string> parseSource)
        {
            List<string> invalidStrings = new List<string>();
            foreach (string s in parseSource)
            {
                bool isValid = IsValidVote(s);
                if (!isValid)
                {
                    invalidStrings.Add(s);
                }
            }
            return invalidStrings;
        }

        private static ParseResult ParseTops(Settings settings, List<string> parseSource)
        {
            ParseResult parseResult = new ParseResult();
            parseResult.TotalStringList.AddRange(parseSource);
            List<string> invalidVoteStrings = GetInvalidVoteStrings(parseSource);
            parseResult.InvalidVoteStrings.AddRange(invalidVoteStrings);

            Dictionary<int, string> currentSourceMap = GetIndexedSourceMap(parseSource);
            int calcLength = settings.CalcLength;
            while (currentSourceMap.Count > 0)
            {
                string votePattern = GetVotePattern(currentSourceMap, calcLength);
                bool isFoundVotePattern = !string.IsNullOrEmpty(votePattern) && currentSourceMap.Count > 0;
                if (isFoundVotePattern)
                {
                    Top top = GetTop(votePattern, currentSourceMap, calcLength);
                    foreach (Vote vote in top.Votes)
                    {
                        currentSourceMap.Remove(vote.GlobalRowIndex);
                    }
                    parseResult.TopList.Add(top);
                }
                else
                {
                    currentSourceMap.Clear();
                }
            }
            return parseResult;
        }

        private static Top GetTop(string votePattern, Dictionary<int, string> currentSourceMap, int calcLength)
        {
            try
            {
                Top top = new Top(votePattern);
                string postNo = "xxx";
                foreach (KeyValuePair<int, string> sourcePair in currentSourceMap)
                {
                    string str = sourcePair.Value;
                    int otIndex = str.IndexOf("ОТ:", StringComparison.Ordinal);
                    if (otIndex>=0)
                    {
                        postNo = str.Substring(0, str.Length - (str.Length - otIndex));
                    }
                    var subStrMax = calcLength;
                    if (subStrMax > votePattern.Length)
                    {
                        subStrMax = votePattern.Length;
                    }
                    bool isValidVoteStr = IsValidVote(str); 
                    if (isValidVoteStr)
                    {
                        if ((str.Length >= (subStrMax + 4)) && (str.Substring(4, subStrMax).Contains(votePattern)))
                        {
                            string albumName = str.Substring(4, str.Length - 4);
                            int place;
                            bool isParsed = int.TryParse(str.Substring(0, 2), NumberStyles.Number, null,
                                out place);
                            if (isParsed)
                            {
                                top.AddVote(place, albumName, postNo, sourcePair.Key);
                            }
                        }
                    }
                }
                return top;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка в методе GetTop", ex);
            }
        }

        private static Dictionary<int, string> GetIndexedSourceMap(IEnumerable<string> parseSource)
        {
            var currentSourceMap = new Dictionary<int, string>();
            int j = 0;
            foreach (var topString in parseSource)
            {
                currentSourceMap.Add(j, topString);
                j++;
            }
            return currentSourceMap;
        }

        private static string GetVotePattern(Dictionary<int, string> currentSourceMap, int calcLength)
        {
            string votePattern = string.Empty;
            try
            {
                foreach (KeyValuePair<int, string> votePair in currentSourceMap)
                {
                    string str = votePair.Value;
                    bool isValidVote = IsValidVote(str);
                    if (isValidVote)
                    {
                        if (str.Length >= (4 + calcLength))
                        {
                            votePattern = str.Substring(4, calcLength);
                        }
                        else
                        {
                            votePattern = str.Substring(4, str.Length - 4);
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка в методе GetVotePattern", ex);
            }
            return votePattern;
        }


        public static Dictionary<string, List<int>> GetAllAlbumNamesWithGlobalLocation(List<Top> tops)
        {
            var albumNames = new Dictionary<string, List<int>>();
            foreach (var top in tops)
            {
                foreach (var topPlace in top.Votes)
                {
                    bool isExistName = albumNames.ContainsKey(topPlace.AlbumName);
                    if (!isExistName)
                    {
                        albumNames.Add(topPlace.AlbumName, new List<int> {topPlace.GlobalRowIndex});
                    }
                    else
                    {
                        albumNames[topPlace.AlbumName].Add(topPlace.GlobalRowIndex);
                    }
                }
            }
            return albumNames;
        }


        public static string GetStringPlace(int number)
        {
            string result = "";
            if (number < 10)
            {
                result += "0";
            }
            result += number;
            result += ". ";
            return result;
        }

        private static int GetMaxPostCodeLength(IEnumerable<Top> albumtops)
        {
            int maxLength = 0;
            foreach (var albumtop in albumtops)
            {
                foreach (var topPlace in albumtop.Votes)
                {
                    int postCodeLength = topPlace.PostNoStr.Length;
                    if (postCodeLength > maxLength)
                    {
                        maxLength = postCodeLength;
                    }
                }
            }
            return maxLength;
        }

        private static string GetPostName(string postCode, int maxPostCodeLength)
        {
            string result = " (" + postCode;
            if (postCode.Length < maxPostCodeLength)
            {
                for (int i = 0; i < maxPostCodeLength - postCode.Length; i++)
                {
                    result += " ";
                }
            }
            result += ")";
            return result;
        }

        public static bool IsValidVote(string str)
        {
            bool isValidVote = false;
            char firstSymbol = '*';
            char secondSymbol = '*';
            char thirdSymbol = '*';
            if (str.Length > 3)
            {
                firstSymbol = str[0];
                secondSymbol = str[1];
                thirdSymbol = str[2];
            }
            bool isValidFirstSymbol = firstSymbol == '0' || firstSymbol == '1' || firstSymbol == '2';
            if (isValidFirstSymbol)
            {
                bool isValidThirdSymbol = thirdSymbol == '.';
                if (isValidThirdSymbol)
                {
                    bool isValidSecondSymbol = Char.IsDigit(secondSymbol);
                    isValidVote = isValidSecondSymbol;
                }
            }
            return isValidVote;
        }
    }
}