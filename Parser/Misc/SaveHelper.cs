using System;
using System.Collections.Generic;
using System.Linq;
using TopHtmlParser.ParseTop;
using TopHtmlParser.UI;

namespace TopHtmlParser.Misc
{
    public static class SaveHelper
    {
        public static void SaveTops(List<UserComment> tops, ParseConfig parseConfig)
        {
            var htmlParseResult = GetHtmlParseResult(tops, parseConfig);

        }

        public static HtmlParseResult GetHtmlParseResult(List<UserComment> tops, ParseConfig parseConfig)
        {
            HtmlParseResult htmlParseResult = new HtmlParseResult();
            List<UserComment> incorrectTopsByUserRegDate = GetWrongRegTops(tops, parseConfig.IsCheckUserRegDate,
                parseConfig.UserRegDateForCheck);
            List<UserComment> incorrectDoubleTops = GetDoubleTops(tops);
            List<UserComment> normalTops =
                tops.Where(
                    userTopBlock =>
                        !incorrectTopsByUserRegDate.Contains(userTopBlock) &&
                        !incorrectDoubleTops.Contains(userTopBlock))
                    .ToList();

            if (normalTops.Count > 0)
            {
                List<string> topsText = GetTopsText(normalTops, false);
                htmlParseResult.Tops.AddRange(topsText);
            }
            if (incorrectTopsByUserRegDate.Count > 0)
            {
                List<string> topsText = GetTopsText(incorrectTopsByUserRegDate, true);
                htmlParseResult.IncorrectTopsByUserRegDate.AddRange(topsText);
            }
            if (incorrectDoubleTops.Count > 0)
            {
                List<string> topsText = GetTopsText(incorrectDoubleTops, true);
                htmlParseResult.IncorrectDoubleTops.AddRange(topsText);
            }
            return htmlParseResult;
        }

        public static List<string> GetTopsText(List<UserComment> tops, bool isIncorrect)
        {
            List<string> topsText = new List<string>();
            foreach (var top in tops)
            {
                topsText.Add(top.ID + " от:" + top.User);
                topsText.Add("Зарегистрирован: " + top.UserRegDate);
                for (int i = 1; i <= top.Comment.Count; i++)
                {
                    string commStr = top.Comment[i];
                    if (commStr.Length > 1 && commStr[1] == '.')
                    {
                        commStr = "0" + commStr;
                    }
                    topsText.Add(commStr);
                }
                topsText.Add("");
            }
            if (isIncorrect)
            {
                topsText.Add("Число некорректных топов:" + tops.Count);
            }
            else
            {
                topsText.Add("Число топов:" + tops.Count);
            }
            return topsText;
        }


        private static List<UserComment> GetWrongRegTops(IEnumerable<UserComment> tops, bool isFiltrateByRegDate,
            DateTime regTimeFrontier)
        {
            if (isFiltrateByRegDate)
            {
                return tops.Where(userTopBlock => userTopBlock.UserRegDate >= regTimeFrontier).ToList();
            }
            return new List<UserComment>();
        }

        private static List<UserComment> GetDoubleTops(List<UserComment> tops)
        {
            var doubleBlocks = new List<UserComment>();
            foreach (var userTopBlock in tops.ToArray())
            {
                UserComment currentBlock = userTopBlock;
                foreach (var otherBlock in tops.ToArray())
                {
                    if (currentBlock != otherBlock)
                    {
                        if (currentBlock.User.ToLower().Trim() == otherBlock.User.ToLower().Trim())
                        {
                            if (!doubleBlocks.Contains(otherBlock))
                            {
                                doubleBlocks.Add(otherBlock);
                            }
                        }
                    }
                }
            }
            return doubleBlocks;
        }
    }
}