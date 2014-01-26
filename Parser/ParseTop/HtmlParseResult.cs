using System.Collections.Generic;

namespace TopHtmlParser.ParseTop
{
    public class HtmlParseResult
    {
        public List<string> Tops { get; private set; }
        public List<string> IncorrectTopsByUserRegDate { get; private set; }
        public List<string> IncorrectDoubleTops { get; private set; }

        public HtmlParseResult()
        {
            Tops = new List<string>();
            IncorrectDoubleTops = new List<string>();
            IncorrectTopsByUserRegDate = new List<string>();
        }
    }
}