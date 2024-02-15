using LeetCodePlayGround.Personal;

namespace LeetCodePlaygroundTests.PersonalTests
{
    public class BinaryConvertorTests
    {
        //Arrange
        //Act
        //Assert



        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test1()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(27);
            Assert.Equal("11011", binaryNumber);
        }

        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test2()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(5);
            Assert.Equal("101", binaryNumber);

        }

        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test3()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(420);
            Assert.Equal("110100100", binaryNumber);

        }

        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test4()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(763);
            Assert.Equal("1011111011", binaryNumber);

        }

        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test5()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(1289374);
            Assert.Equal("100111010110010011110", binaryNumber);

        }

        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test6()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(1);
            Assert.Equal("1", binaryNumber);
        }

        [Fact]
        public void BinaryConverter_ConvertNumberToBinary_Test7()
        {
            string binaryNumber = BinaryConvertor.ConvertNumberToBinary(0);
            Assert.Equal("0", binaryNumber);
        }



        /*----------------------------------------------------------------------------*/

        [Fact]
        public void BinaryConverter_ConvertBinaryToNumber_Test1()
        {
            int number = BinaryConvertor.ConvertBinaryToNumber(101);
            Assert.Equal(5, number);
        }

        [Fact]
        public void BinaryConverter_ConvertBinaryToNumber_Test2()
        {
            int number = BinaryConvertor.ConvertBinaryToNumber(11011);
            Assert.Equal(27, number);
        }

        [Fact]
        public void BinaryConverter_ConvertBinaryToNumber_Test3()
        {
            int number = BinaryConvertor.ConvertBinaryToNumber(1001101);
            Assert.Equal(77, number);
        }

        [Fact]
        public void BinaryConverter_ConvertBinaryToNumber_Test4()
        {
            int number = BinaryConvertor.ConvertBinaryToNumber(1011101110);
            Assert.Equal(750, number);
        }

        [Fact]
        public void BinaryConverter_ConvertBinaryToNumber_Test5()
        {
            int number = BinaryConvertor.ConvertBinaryToNumber(1);
            Assert.Equal(1, number);
        }

        [Fact]
        public void BinaryConverter_ConvertBinaryToNumber_Test6()
        {
            int number = BinaryConvertor.ConvertBinaryToNumber(0);
            Assert.Equal(0, number);
        }
    }
}