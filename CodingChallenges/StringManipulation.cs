using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public static class StringManipulation
    { 
            #region 1.1Unique
            // Based on Cracking the Coding Interview
        public static bool IsUniqueHashSet(string phrase)
        {
            HashSet<char> characterList = new HashSet<char>();
            foreach (char c in phrase)
            {
                if (characterList.Add(c) == false)
                {
                    // If .Add fails that means the character was already in the Hashset which means it's not unique
                    return false;
                }
            }
            return true;
        }
        public static bool IsUniqueArray(string str)
        {
            if (str.Length > 128)
            {
                return false;
            }
            Boolean[] char_set = new Boolean[128];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }
        #endregion

        #region 1.2Permutation
        public static bool IsPermutation(string phraseOne, string phraseTwo)
        {
            int[] charList = new int[256];
            if (phraseOne.Length != phraseTwo.Length)
            {
                return false;
            }
            foreach (var c in phraseOne)
            {
                charList[c]++;
            }
            foreach (var c in phraseTwo)
            {
                charList[c]--;
                if (charList[c] < 0)
                    return false;
            }
            return true;
        }
        #endregion
    }

}
