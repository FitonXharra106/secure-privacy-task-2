using SecurePrivacyTask2;

namespace SecurePrivacyTask2.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Program"/> class to validate the behavior of the <see cref="Program.IsGoodBinaryString(string)"/> method.
    /// </summary>
    [TestFixture]
    public class BinaryStringEvaluatorTests
    {
        /// <summary>
        /// Tests that a valid good binary string returns true.
        /// Example input: "1100" which contains equal number of '0's and '1's 
        /// and satisfies the prefix condition.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_ValidGoodString_ReturnsTrue()
        {
            // Arrange
            string input = "1100";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Tests that a valid bad binary string returns false.
        /// Example input: "1001" which does not satisfy the conditions
        /// as it has more '0's than '1's in certain prefixes.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_ValidBadString_ReturnsFalse()
        {
            // Arrange
            string input = "1001";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests that an empty string returns false as it doesn't meet the criteria 
        /// for being a good binary string.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_EmptyString_ReturnsFalse()
        {
            // Arrange
            string input = "";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests that a string with only '1's returns false.
        /// Example input: "1111", which has no '0's to balance the '1's.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_OnlyOnes_ReturnsFalse()
        {
            // Arrange
            string input = "1111";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests that a string with only '0's returns false.
        /// Example input: "0000", which has no '1's to balance the '0's.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_OnlyZeros_ReturnsFalse()
        {
            // Arrange
            string input = "0000";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests that a string containing invalid characters returns false.
        /// Example input: "1102", which contains the invalid character '2'.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_InvalidCharacters_ReturnsFalse()
        {
            // Arrange
            string input = "1102"; // Invalid character '2'

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests that a complex binary string returns false.
        /// Example input: "101001", which does not satisfy the conditions for being good.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_ValidComplexString_ReturnsFalse()
        {
            // Arrange
            string input = "101001";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests that another valid binary string returns false.
        /// Example input: "110011", which does not satisfy the good string conditions.
        /// </summary>
        [Test]
        public void IsGoodBinaryString_AnotherValidGoodString_ReturnsFalse()
        {
            // Arrange
            string input = "110011";

            // Act
            bool result = Program.IsGoodBinaryString(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
