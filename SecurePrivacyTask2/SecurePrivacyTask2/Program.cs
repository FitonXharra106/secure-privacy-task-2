namespace SecurePrivacyTask2
{
    public class Program
    {
        /// <summary>
        /// The main entry point of the application. This method contains test cases 
        /// for the IsGoodBinaryString function, which evaluates binary strings based 
        /// on specific criteria.
        /// </summary>
        /// <param name="args">Command line arguments (not used).</param>
        static void Main(string[] args)
        {
            // Test cases for evaluating binary strings
            Console.WriteLine(IsGoodBinaryString("1100"));    // Expected: True
            Console.WriteLine(IsGoodBinaryString("1001"));    // Expected: False
            Console.WriteLine(IsGoodBinaryString("111000"));   // Expected: True
            Console.WriteLine(IsGoodBinaryString("1010"));     // Expected: True
            Console.WriteLine(IsGoodBinaryString(""));          // Expected: False (empty string)
            Console.WriteLine(IsGoodBinaryString("1111"));      // Expected: False (not enough 0s)
            Console.WriteLine(IsGoodBinaryString("0000"));      // Expected: False (not enough 1s)
            Console.WriteLine(IsGoodBinaryString("101001"));    // Expected: False (invalid prefix)
            Console.WriteLine(IsGoodBinaryString("110011"));    // Expected: False
        }

        /// <summary>
        /// Determines if a binary string is "good" based on specific criteria:
        /// 1. The string contains an equal number of '0's and '1's.
        /// 2. For every prefix of the string, the count of '1's is not less than the count of '0's.
        /// 
        /// The method treats an empty string or a string with invalid characters 
        /// as not good.
        /// </summary>
        /// <param name="binaryString">The binary string to evaluate, which must contain only '0' and '1' characters.</param>
        /// <returns>True if the binary string meets the conditions of a "good" string; otherwise, false.</returns>
        public static bool IsGoodBinaryString(string binaryString)
        {
            // Immediately return false for an empty string
            if (string.IsNullOrEmpty(binaryString))
            {
                return false; // Treat empty string as not good
            }

            int count0 = 0; // Count of '0's
            int count1 = 0; // Count of '1's

            // Iterate through each character in the binary string
            foreach (char ch in binaryString)
            {
                if (ch == '1')
                {
                    count1++; // Increment the count of '1's
                }
                else if (ch == '0')
                {
                    count0++; // Increment the count of '0's
                }
                else
                {
                    return false; // Treat non-binary input as invalid
                }

                // If at any point the number of '0's exceeds the number of '1's, return false.
                if (count0 > count1)
                {
                    return false; // Invalid prefix condition
                }
            }

            // Check if the counts of '0's and '1's are equal
            return count0 == count1; // Must be equal counts of '0's and '1's
        }
    }
}