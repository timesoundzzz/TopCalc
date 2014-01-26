using System.Collections.Generic;

namespace TopHtmlParser
{



   public class Top
    {
       public Top(string gName)
       {
           Name = gName;
           TopPlaces = new List<TopPlace>();
           Places = new List<string>();
           Sum = 0;
       }

        public string Name;
        public List<TopPlace> TopPlaces; 
        public List<string> Places;
        public int Sum;

       public void AddPlace(int place, string post, string name, int globalRowIndex)
       {
           var topPlace = new TopPlace();
           topPlace.Album = name;
           topPlace.Post = post;
           topPlace.Place = place;
           topPlace.GlobalRowIndex = globalRowIndex;
           topPlace.IsErrorPlace = place < 1 || place > 20;
           if (!topPlace.IsErrorPlace)
           {
               Sum += 21 - place;
           }
           TopPlaces.Add(topPlace);
       }

       public void ChangePlace(int place, string newName)
       {
           Places[place] = newName;
       }
    }
}
