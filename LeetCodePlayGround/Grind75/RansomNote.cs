using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.Grind75
{
    public class RansomNote
    {
        //ransomnote into a char[] array or list<char> for .remove()
        //foreach char in magazine if char[] contains that letter
        //remove it
        //if char[] is empty return true other wise false

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> ransomCharList = ransomNote.ToList();

            foreach (var c in magazine)
            {
                if (ransomCharList.Contains(c))
                {
                    ransomCharList.Remove(c);
                }
            }

            if (ransomCharList.Count == 0)
            {
                return true;
            }

            return false;

        }
    }
}
