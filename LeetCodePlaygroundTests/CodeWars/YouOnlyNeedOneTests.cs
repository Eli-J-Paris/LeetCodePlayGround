using LeetCodePlayGround.CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePlaygroundTests.CodeWars
{
    public class YouOnlyNeedOneTests
    {
        [Fact]
        public void Solution_ReturnsTrue_WhenElementExists()
        {
            // Arrange
            object[] array = { 1, 2, 3, 4, 5 };
            object target = 3;

            // Act
            bool result = YouOnlyNeedOne.Solution(array, target);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Solution_ReturnsFalse_WhenElementDoesNotExist()
        {
            // Arrange
            object[] array = { 1, 2, 3, 4, 5 };
            object target = 6;

            // Act
            bool result = YouOnlyNeedOne.Solution(array, target);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Solution_ReturnsFalse_WhenArrayIsEmpty()
        {
            // Arrange
            object[] array = { };
            object target = 1;

            // Act
            bool result = YouOnlyNeedOne.Solution(array, target);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Solution_ReturnsTrue_WhenElementIsString()
        {
            // Arrange
            object[] array = { "apple", "banana", "orange" };
            object target = "banana";

            // Act
            bool result = YouOnlyNeedOne.Solution(array, target);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Solution_ReturnsFalse_WhenElementIsNotString()
        {
            // Arrange
            object[] array = { "apple", "banana", "orange" };
            object target = 1;

            // Act
            bool result = YouOnlyNeedOne.Solution(array, target);

            // Assert
            Assert.False(result);
        }

    }
}
