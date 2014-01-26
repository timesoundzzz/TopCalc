using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace TopHtmlParser.ParseTop
{
    public static class TopBuilderAP2013
    {
        public static List<UserComment> GetTops(HtmlNode nodeWithComments)
        {
            List<CommAP2013> topComments = GetTopComments(nodeWithComments);
            var tops = new List<UserComment>();
            foreach (var comm in topComments)
            {
                UserComment top = GetTopByComment(comm);
                if (top != null)
                {
                    tops.Add(top);
                }
            }
            return tops;
        }

        public static List<CommAP2013> GetTopComments(HtmlNode nodeWithComments)
        {
            var topComments = new List<CommAP2013>();
            foreach (HtmlNode node in nodeWithComments.ChildNodes)
            {
                HtmlNode header = GetCommHeader(node);
                HtmlNode body = GetCommBody(node);
                HtmlNode footer = GetCommFooter(node);
                if (header != null && body != null && footer != null)
                {
                    CommAP2013 comm = new CommAP2013(header, body, footer);
                    topComments.Add(comm);
                }
            }
            return topComments;
        }

        private static HtmlNode GetCommHeader(HtmlNode nodeContentChild)
        {
            HtmlNode header =
                nodeContentChild.Descendants()
                    .Where(
                        d =>
                            d.HasAttributes && d.Attributes.Contains("class") &&
                            d.Attributes["class"].Value.Contains("abl_12")).ToList().FirstOrDefault();
            return header;
        }

        private static HtmlNode GetCommBody(HtmlNode nodeContentChild)
        {
            HtmlNode commBody =
                nodeContentChild.Descendants()
                    .Where(
                        d =>
                            d.HasAttributes && d.Attributes.Contains("id") &&
                            d.Attributes["id"].Value.IndexOf("comm") == 0).ToList().FirstOrDefault();
            return commBody;
        }

        private static HtmlNode GetCommFooter(HtmlNode nodeContentChild)
        {
            HtmlNode footer =
                nodeContentChild.Descendants()
                    .Where(
                        d =>
                            d.HasAttributes && d.Attributes.Contains("class") &&
                            d.Attributes["class"].Value.Contains("abl_52")).ToList().FirstOrDefault();
            return footer;
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
                        nodeWithComments = node.ParentNode;
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

        private static UserComment GetTopByComment(CommAP2013 comment)
        {
            UserComment top = new UserComment();
            HtmlNode headerNode = comment.Header.ChildNodes[0].ChildNodes[1].ChildNodes[1];
            top.ID = headerNode.ChildNodes[0].InnerText;
            top.ID = top.ID.Substring(0, top.ID.Length - 10);//убираем "Написал:"
            top.User = headerNode.ChildNodes[1].InnerText;
            top.Time = headerNode.ChildNodes[2].InnerText;
            HtmlNode regNode = comment.Footer.ChildNodes[0].ChildNodes[1].ChildNodes[3].ChildNodes[0];
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
            HtmlNode commNode = comment.Body;

            string topLine = string.Empty;
            topLine = AddLine(commNode, top, ref topLine);

            if (topLine != string.Empty)
            {
                int counter = top.Comment.Count + 1;
                top.Comment.Add(counter, topLine);
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