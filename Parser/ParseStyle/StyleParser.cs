using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using TopHtmlParser.ParseTop;

namespace TopHtmlParser.ParseStyle
{
    public class StyleParser
    {
        public static List<UserComment> GetTops(HtmlNode nodeWithComments)
        {
            SortedList<int, HtmlNode> topNodes = GetTopNodes(nodeWithComments);

            var tops = new List<UserComment>();
            foreach (var htmlNode in topNodes)
            {
                UserComment top = GetTopByTotalTopNode(htmlNode.Value);
                if (top != null)
                {
                    tops.Add(top);
                }
            }
            return tops;
        }

        public static SortedList<int, HtmlNode> GetTopNodes(HtmlNode nodeWithComments)
        {
            var topNodes = new SortedList<int, HtmlNode>();
            int counter = -1;
            for (int i = 0; i < nodeWithComments.ChildNodes.Count; i++)
            {
                HtmlNode node = nodeWithComments.ChildNodes[i];
                bool isNodeTop = IsNodeTop(node);
                if (isNodeTop)
                {
                    counter++;
                    topNodes.Add(counter, node);
                }
            }
            return topNodes;
        }

        public static bool IsNodeTop(HtmlNode node)
        {
            bool isNodeTop = false;
            string nodeText = node.InnerText.ToLower();
            isNodeTop = nodeText.Contains("comm");
            isNodeTop = isNodeTop || nodeText.Contains("от:");
            if (!isNodeTop)
            {
                const string regStr = "Регистрация:";
                isNodeTop = nodeText.Contains(regStr);
            }
            return isNodeTop;
        }

        private static UserComment GetTopByTotalTopNode(HtmlNode node)
        {
            UserComment top = null;
            HtmlNode tableNode = null;
            foreach (var childNode in node.ChildNodes)
            {
                if (childNode.Name == "table")
                {
                    tableNode = childNode;
                    break;
                }
            }
            if (tableNode != null && (tableNode.ChildNodes.Count == 9 || tableNode.ChildNodes.Count == 11))
            {
                top = new UserComment();
                HtmlNode userNode = tableNode.ChildNodes[3].ChildNodes[1];
                top.ID = userNode.ChildNodes[0].InnerText;
                top.User = userNode.ChildNodes[2].InnerText;
                top.Time = userNode.ChildNodes[3].InnerText;
                HtmlNode regNode = tableNode.ChildNodes[5].ChildNodes[1];
                string regTime = regNode.InnerText;
                regTime = regTime.Substring(13, 10);
                if (!Char.IsDigit(regTime[9]))
                {
                    regTime = "0" + regTime.Substring(0, 9);
                }
                top.UserRegDate = DateTime.ParseExact(regTime, "dd.MM.yyyy", null);
                HtmlNode commNode = tableNode.ChildNodes[7].ChildNodes[3].ChildNodes[0];


                string topLine = string.Empty;
                topLine = AddLine(commNode, top, ref topLine);
                if (topLine != string.Empty)
                {
                    int counter = top.Comment.Count + 1;
                    top.Comment.Add(counter, topLine);
                }
            }
            return top;
        }


        private static string AddLine(HtmlNode htmlNode, UserComment top, ref string topLine)
        {
            if (htmlNode.Name == "#text")
            {
                string nodetext = htmlNode.InnerText;
                topLine += nodetext;
            }
            else if (htmlNode.Name.Contains("br"))
            {
                if (topLine != string.Empty)
                {
                    int counter = top.Comment.Count + 1;
                    top.Comment.Add(counter, topLine);
                    topLine = string.Empty;
                }
            }
            foreach (var attribute in htmlNode.Attributes)
            {
                if (attribute.Name == "title")
                {
                    top.User = attribute.Value;
                }
            }
            foreach (var childNode in htmlNode.ChildNodes)
            {
                AddLine(childNode, top, ref topLine);
            }
            return topLine;
        }


        public static string GetNextUrl(HtmlDocument document)
        {
            string nextUrl = string.Empty;
            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//a");
            foreach (HtmlNode node in collection)
            {
                if (node.InnerText.ToLower() == "далее")
                {
                    foreach (var attribute in node.Attributes)
                    {
                        bool isContentNode = attribute.Name.ToLower() == "href";
                        if (isContentNode)
                        {
                            nextUrl = attribute.Value;
                            break;
                        }
                    }
                }
                if (nextUrl != string.Empty)
                {
                    break;
                }
            }
            return nextUrl;
        }

        public static List<UserComment> GetNodesWithComments(HtmlDocument document)
        {
            var tops = new List<UserComment>();
            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//td[@class='fulstory']");
            foreach (HtmlNode node in collection.ToList())
            {
                HtmlNode userNode = node;
                var top = new UserComment ();
                string topLine = string.Empty;
                AddLine(userNode, top, ref topLine);
                bool isValidTop = false;
                string validStyleStr = string.Empty;
                foreach (var str in top.Comment.Values)
                {
                    isValidTop = str.Contains("Стиль");
                    if (isValidTop)
                    {
                        validStyleStr = str;
                        break;
                    }
                }
                if (isValidTop)
                {
                    top.Comment.Clear();
                    top.Comment.Add(1, validStyleStr);
                    tops.Add(top);
                }
            }
            return tops;
        }
    }
}