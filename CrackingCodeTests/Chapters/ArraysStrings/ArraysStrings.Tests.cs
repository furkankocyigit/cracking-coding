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

        [DataTestMethod]
        [DataRow("furkan", "frknau", true)]
        [DataRow("abcde", "abcdex", false)]
        [DataRow("abcde", "abcdb", false)]
        [DataRow("xyzabc", "xzyCba", false)]
        [DataRow("xyzabc", "cabzyx", true)]
        public void isPermutationTest(string first, string second, bool expectedResult)
        {
            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            bool output = testObject.isPermutation(first, second);

            Assert.AreEqual(expectedResult, output);

        }

        [TestMethod]
        public void zeroMatrixTest()
        {
            int[,] matrix = new int[3, 3] { { 1, 1, 1 },
                                            { 2, 0, 2 },
                                            { 3, 3, 3 } };

            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            testObject.zeroMatrix(matrix);

            Assert.AreEqual(0, matrix[0, 1]);
            Assert.AreEqual(0, matrix[1, 1]);
            Assert.AreEqual(0, matrix[2, 1]);
            Assert.AreEqual(0, matrix[1, 0]);
            Assert.AreEqual(0, matrix[1, 1]);
            Assert.AreEqual(0, matrix[1, 2]);
        }

        [TestMethod]
        public void zeroMatrixTest2()
        {
            int[,] matrix = new int[3, 4] { { 1, 1, 1, 1 },
                                            { 2, 2, 2, 2 },
                                            { 3, 3, 0 ,3}, };

            ArraysAndStringSolutions testObject = new ArraysAndStringSolutions();

            testObject.zeroMatrix(matrix);

            Assert.AreEqual(0, matrix[0, 2]);
            Assert.AreEqual(0, matrix[1, 2]);
            Assert.AreEqual(0, matrix[2, 2]);
            Assert.AreEqual(0, matrix[2, 0]);
            Assert.AreEqual(0, matrix[2, 1]);
            Assert.AreEqual(0, matrix[2, 2]);
            Assert.AreEqual(0, matrix[2, 3]);
        }
    }

}
