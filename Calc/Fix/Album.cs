using System.Collections.Generic;

namespace TopCalc.Fix
{
    public class Album
    {
        public string NameIn { get; set; }
        public string NameOut { get; set; }
        public List<int> GlobalRowIndices { get; private set; } 

        public Album(string name, List<int> globalRowIndices )
        {
            NameIn = name;
            NameOut = name;
            GlobalRowIndices = globalRowIndices;
        }
    }
}
