using CrackingCoding.Chapters.ArraysStrings;

namespace CrackingCodeTests.Chapters.ArraysStrings
{
    [TestClass]
    public class ArraysStringsTests
    {
        [DataTestMethod]
        [DataRow("abcdef", true)]
        [DataRow("abcdea", false)]
        [DataRow("abcdeA", true)]
        [DataRow("abcdef g", true)]
        [DataRow("abcdef b", false)]
        public void isStringUniqTest(string input, bool expectedResult)
        {
            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            bool output = testObject.isStringUniq(input);
            bool output2 = testObject.isStringUniqSecondSolution(input);

            Assert.AreEqual(expectedResult, output);
            Assert.AreEqual(expectedResult, output2);
        }

        [DataTestMethod]
        [DataRow("aabcccccaaa", "a2b1c5a3")]
        [DataRow("aaabbcccddddee", "a3b2c3d4e2")]
        [DataRow("abccdeff", "abccdeff")]
        [DataRow("xxyyycdfaa", "xxyyycdfaa")]
        public void compressedStringTest(string inputString, string expectedCompressedString)
        {
            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            string compressedString = testObject.compressString(inputString);
            string compressedStringSecond = testObject.compressStringSecond(inputString);

            Assert.AreEqual(expectedCompressedString, compressedString);
            Assert.AreEqual(expectedCompressedString, compressedStringSecond);
        }
    }
}
