using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    public class ListFiltering
    {

        public static IEnumerable<int> GetIntergersFromList(List<object> listOfItems)
        {
            List<int> trueInts = new List<int>();

            foreach(var element in listOfItems)
            {
                if(element is int)
                {
                    trueInts.Add((int)element);
                }
            }
            return trueInts;
        }
    }
}
