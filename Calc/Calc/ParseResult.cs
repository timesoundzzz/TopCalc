using System.Collections.Generic;

namespace TopCalc.Calc
{
    public class ParseResult
    {
        public List<Top> TopList { get; private set; }
        public List<string> InvalidVoteStrings { get; private set; }
        public List<string> TotalStringList { get; private set; }

        public ParseResult()
        {
            TopList = new List<Top>();
            InvalidVoteStrings = new List<string>();
            TotalStringList = new List<string>();
        }
    }
}