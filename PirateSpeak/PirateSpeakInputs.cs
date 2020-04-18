using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateSpeak
{
    public class PirateSpeakInputs
    {
        public List<string> PirateInputs(string incomingWord, List<string> incomingList)
        {
            List<string> returnedWords = new List<string>();
            List<string> trashWords = new List<string>();
            var charIncoming = incomingWord.ToCharArray();

            for (int i = 0; i < incomingWord.Length; i++)
            {
                trashWords = incomingList.Where(item => item.Contains(charIncoming[i])).ToList();
            }
            foreach (var stuff in trashWords)
            {
                if (stuff.Length == incomingWord.Length)
                {
                    returnedWords.Add(stuff);
                }
            }
            return returnedWords;
        }
    }
}