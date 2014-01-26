using System;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace AlterSideTopCalc
{
    public static class Alterside2011TopBuilder
    {
        public static List<UserTopBlock> GetTops(HtmlNode nodeWithComments)
        {

            SortedList<int, HtmlNode> topNodes = GetTopNodes(nodeWithComments);

            var tops = new List<UserTopBlock>();
            foreach (var htmlNode in topNodes)
            {
                UserTopBlock top = GetTopByTotalTopNode(htmlNode.Value);
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

        private static UserTopBlock GetTopByTotalTopNode(HtmlNode node)
        {
            UserTopBlock top = null;
            HtmlNode tableNode = null;
            foreach (var childNode in node.ChildNodes)
            {
                if (childNode.Name == "table")
                {
                    tableNode = childNode;
                    break;
                }
            }
            if (tableNode != null && (tableNode.ChildNodes.Count == 9||tableNode.ChildNodes.Count == 11))
            {
                top = new UserTopBlock();
                HtmlNode userNode = tableNode.ChildNodes[3].ChildNodes[1];
                top.CommentID = userNode.ChildNodes[0].InnerText;
                top.CommentUser = userNode.ChildNodes[2].InnerText;
                top.CommentTime = userNode.ChildNodes[3].InnerText;         
                HtmlNode regNode = tableNode.ChildNodes[5].ChildNodes[1];
                string regTime = regNode.InnerText;
                regTime = regTime.Substring(13, 10);
                if (!Char.IsDigit(regTime[9]))
                {
                    regTime = "0"+regTime.Substring(0, 9);
                }
                top.RegistrationDate = DateTime.ParseExact(regTime, "dd.MM.yyyy", null);
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


        private static  string AddLine(HtmlNode htmlNode, UserTopBlock top, ref string topLine)
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
    }
}
