using System.Collections.Generic;

namespace TopCalc.Calc
{
    public class CalcResult
    {
        public Dictionary<Top, int> SumMap { get; private set; }
        public List<string> ResultTxtOut { get; private set; }
        public List<string> CheckPostTxtOut { get; private set; }
        public List<string> CheckNameTxtOut { get; private set; } 
        public CalcResult(IEnumerable<Top> tops)
        {
            SumMap = new Dictionary<Top, int>();
            ResultTxtOut = new List<string>();
            CheckPostTxtOut = new List<string>();
            CheckNameTxtOut = new List<string>();
            FillSumMap(tops);
        }

        private void FillSumMap(IEnumerable<Top> tops)
        {
            foreach (Top top in tops)
            {
                int topTotalSum = 0;
                foreach (Vote vote in top.Votes)
                {
                    topTotalSum += vote.Sum;
                }
                SumMap.Add(top, topTotalSum);
            }
        }
    }
}
