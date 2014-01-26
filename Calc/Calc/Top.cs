using System.Collections.Generic;

namespace TopCalc.Calc
{
    public class Top
    {
        public string Name;
        public List<Vote> Votes;
        public List<string> Places;

        public Top(string gName)
        {
            Name = gName;
            Votes = new List<Vote>();
            Places = new List<string>();
        }

        public void AddVote(int place, string albumName, string postNo, int globalRowIndex)
        {
            Vote vote = new Vote
            {
                AlbumName = albumName,
                PostNoStr = postNo,
                Place = place,
                GlobalRowIndex = globalRowIndex,
            };
            if (place >= 1 && place <= 20)
            {
                vote.State = VoteState.Normal;
            }
            else
            {
                vote.State = VoteState.Error;
            }
            Votes.Add(vote);
        }

        public void ChangePlace(int place, string newName)
        {
            Places[place] = newName;
        }
    }
}