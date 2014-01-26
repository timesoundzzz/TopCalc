using HtmlAgilityPack;

namespace TopHtmlParser.ParseTop
{
    public class CommAP2013
    {
        public HtmlNode Header { get; private set; }
        public HtmlNode Body { get; private set; }
        public HtmlNode Footer { get; private set; }

        public CommAP2013(HtmlNode header, HtmlNode body, HtmlNode footer)
        {
            Header = header;
            Body = body;
            Footer = footer;
        }
    }
}