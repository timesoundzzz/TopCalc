using System;
using System.Collections.Generic;

namespace AlterSideTopCalc
{
    public class UserTopBlock
    {
        public string CommentID { get; set; }
        public string CommentUser { get; set; }
        public string CommentTime { get; set; }
        public DateTime RegistrationDate { get; set; }
        public SortedList<int, string> Comment { get; set; }

        public UserTopBlock()
        {
            Comment = new SortedList<int, string>();
        }
    }
}