using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlayGround.CodeWars
{
    enum Lights
    {
        green,
        yellow,
        red
    }
    public class TrafficLight
    {
        public static string UpdateLight(string current)
        {
            if (current.ToLower() == "green") return "yellow";
            else if (current.ToLower() == "yellow") return "red";
            else return "green";     
        }
    }
}
