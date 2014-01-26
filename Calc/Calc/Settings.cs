namespace TopCalc.Calc
{
    public class Settings
    {
        public string TopFileName { get; set; }
        public string SaveResultsFileName { get; set; }
        public string SaveCheckFileName { get; set; }
        public string SaveFixedFileName { get; set; }
        public int CalcLength { get; set; }

        public Settings()
        {
            CalcLength = 7;
            TopFileName = string.Empty;
            SaveResultsFileName = "Results.txt";
            SaveCheckFileName = "Check.txt";
            SaveFixedFileName = "Fixed.txt";
        }
    }
}