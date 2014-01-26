using System;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace TopHtmlParser.ParseTop
{
    public static class TopBuilderAP2012
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
            foreach (HtmlNode node in nodeWithComments.ChildNodes)
            {
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
            string nodeText = node.InnerText.ToLower();
            bool isNodeTop = nodeText.Contains("comm");
            isNodeTop = isNodeTop || nodeText.Contains("от:");
            if (!isNodeTop)
            {
                const string regStr = "зарегистрирован";
                isNodeTop = nodeText.Contains(regStr);
            }
            return isNodeTop;
        }

        public static HtmlNode GetNodesWithComments(HtmlDocument document)
        {
            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//div");
            HtmlNode nodeWithComments = null;
            foreach (HtmlNode node in collection)
            {
                foreach (var attribute in node.Attributes)
                {
                    bool isContentNode = attribute.Name.ToLower() == "id" && attribute.Value.ToLower() == "dle-content";
                    if (isContentNode)
                    {
                        nodeWithComments = node;
                        break;
                    }
                }
                if (nodeWithComments != null)
                {
                    break;
                }
            }
            return nodeWithComments;
        }

        private static UserComment GetTopByTotalTopNode(HtmlNode node)
        {
            UserComment top = null;
            HtmlNode tableNode = node;
            if (tableNode != null && tableNode.ChildNodes.Count == 11)
            {
                top = new UserComment();
                HtmlNode userNode = tableNode.ChildNodes[1].ChildNodes[3].ChildNodes[0].ChildNodes[1].ChildNodes[1];
                top.ID = userNode.ChildNodes[0].InnerText;
                top.ID = top.ID.Substring(0, top.ID.Length - 10);
                top.User = userNode.ChildNodes[1].InnerText;
                top.Time = userNode.ChildNodes[2].InnerText;
                HtmlNode regNode =
                    tableNode.ChildNodes[9].ChildNodes[3].ChildNodes[0].ChildNodes[1].ChildNodes[3].ChildNodes[0];
                string regTime = regNode.InnerText;
                int timeStartInd = regTime.IndexOf(":", StringComparison.Ordinal);
                int teimEndInd = regTime.IndexOf("|", StringComparison.Ordinal);
                regTime = regTime.Substring(timeStartInd + 1, (-timeStartInd - 1 + teimEndInd));
                regTime = regTime.Trim();
                if (regTime.Length != 10)
                {
                    regTime = "0" + regTime;
                }
                if (!Char.IsDigit(regTime[9]))
                {
                    regTime = "0" + regTime.Substring(0, 9);
                }
                top.UserRegDate = DateTime.ParseExact(regTime, "dd.MM.yyyy", null);
                HtmlNode commNode =
                    tableNode.ChildNodes[5].ChildNodes[3].ChildNodes[1].ChildNodes[1].ChildNodes[3].ChildNodes[0];
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
    }
}