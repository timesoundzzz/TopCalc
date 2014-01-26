using System;
using System.Collections.Generic;
using System.Linq;

namespace TopCalc.Fix
{
    public class MasterSlave
    {
        public List<Album> AlbumNames { get; private set; }
        public Dictionary<Album, List<Album>> MasterSlaveMap { get; private set; }
 
        public MasterSlave()
        {
            AlbumNames = new List<Album>();
            MasterSlaveMap = new Dictionary<Album, List<Album>>();
        }

        public void FindSlaves(Album albumName)
        {
            var slaves = new List<Album>();

                if (MasterSlaveMap.ContainsKey(albumName))
                {
                    slaves = MasterSlaveMap[albumName];
                }
                else
                {
                    AlbumNames.Remove(albumName);
                    MasterSlaveMap.Add(albumName, slaves);
                }
            var possibleSlaves = new List<Album>();
            
            foreach (var name in AlbumNames.ToList())
            {
                Char[] chars = name.NameOut.ToCharArray();
                List<Char> masterChars = albumName.NameOut.ToList();
                double charsCount = chars.Count();
                double foundChars = 0;
                
                foreach (var c in chars)
                {
                    if (masterChars.Contains(c))
                    {
                        foundChars++;
                        masterChars.Remove(c);
                    }
                }
                if (foundChars/charsCount >= 0.7)
                {
                    possibleSlaves.Add(name);
                }
            }
            //определен список с 90% символов
            //определяем пары с 50%
            var unPosSlaves= new List<Album>();
            foreach (var possibleSlave in possibleSlaves)
            {
                var charPairs = new List<string>();
                int length = possibleSlave.NameOut.Length;
                for (int i = 0; i < length; i++)
                {
                    if (i < length - 1)
                    {
                        charPairs.Add(possibleSlave.NameOut.Substring(i, 2));
                    }
                }
                double pairsCount = charPairs.Count;
                double foundPairs = 0;
                foreach (var charPair in charPairs)
                {
                    if (albumName.NameOut.Contains(charPair))
                    {
                        foundPairs++;
                    }
                }
                if (foundPairs/pairsCount < 0.8)
                {
                    unPosSlaves.Add(possibleSlave);
                }
            }
            foreach (var unPosSlave in unPosSlaves)
            {
                possibleSlaves.Remove(unPosSlave);
            }
            foreach (var slave in possibleSlaves)
            {
                slaves.Add(slave);
                AlbumNames.Remove(slave);
            }
        }
    }
}
