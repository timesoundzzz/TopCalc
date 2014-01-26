using System;
using System.Collections.Generic;

namespace TopHtmlParser.ParseTop
{
    public class UserComment
    {
        public string ID { get; set; }
        public string User { get; set; }
        public string Time { get; set; }
        public DateTime UserRegDate { get; set; }
        public SortedList<int, string> Comment { get; set; }

        public UserComment()
        {
            Comment = new SortedList<int, string>();
        }
    }
}