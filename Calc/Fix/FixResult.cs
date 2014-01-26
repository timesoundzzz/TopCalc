using System;
using System.Collections.Generic;

namespace TopCalc.Fix
{
    public class FixResult
    {
        public List<string> In { get; private set; }
        public List<string> Out { get; private set; }
        public List<string> ChangeLog { get; private set; }

        public FixResult()
        {
            In = new List<string>();
            Out = new List<string>();
            ChangeLog = new List<string>();
        }
    }
}