namespace TopCalc.Calc
{
    public enum VoteState
    {
        Normal, 
        Error
    }

    public class Vote
    {
        public int Place { get; set; }
        public int Sum { get { return 21 - Place; } }
        public string AlbumName { get; set; }
        public string PostNoStr { get; set; }
        public VoteState State { get; set; }
        public int GlobalRowIndex { get; set; }

        public Vote()
        {
            Place = 0;
        }
    }
}
