using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class TrafficLightTests
    {
        [Fact]
        public static void UpdateLight_ChangesGreenToYellow()
        {
            string currentLight = "green";
            string expected = "yellow";

            string result = TrafficLight.UpdateLight(currentLight);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void UpdateLight_ChangesYellowToRed()
        {
            string currentLight = "yellow";
            string expected = "red";

            string result = TrafficLight.UpdateLight(currentLight);

            Assert.Equal(expected, result);
        }

        [Fact]
        public static void UpdateLight_ChangesRedToGreen()
        {
            string currentLight = "red";
            string expected = "green";

            string result = TrafficLight.UpdateLight(currentLight);

            Assert.Equal(expected, result);
        }
    }
}
