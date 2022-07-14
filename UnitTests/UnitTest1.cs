using LeetCode_12_IntToRoman;

namespace UnitTests
{
    public class ProvideInteger
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(21, "XXI")]
        [InlineData(32, "XXXII")]
        [InlineData(43, "XLIII")]
        [InlineData(54, "LIIII")]
        [InlineData(65, "LXV")]
        [InlineData(76, "LXXVI")]
        [InlineData(87, "LXXXVII")]
        [InlineData(98, "XCVIII")]
        [InlineData(100, "C")]
        [InlineData(101, "CI")]
        public void ConvertingToRomanGivesExpectedResult(int num, string expectedResult)
        {
            // Arrange

            // Act
            string actualResult = new Solution().IntToRoman(num);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ThrowsConstraintViolationExceptionWhenOutOfBounds()
        {
            // Arrange
            int num1 = 0;
            int num2 = 4000;

            // Act
            Action action1 = () => new Solution().IntToRoman(num1);
            Action action2 = () => new Solution().IntToRoman(num2);

            // Assert
            Assert.Throws<ConstraintViolationException>(action1);
            Assert.Throws<ConstraintViolationException>(action2);
        }
    }
}