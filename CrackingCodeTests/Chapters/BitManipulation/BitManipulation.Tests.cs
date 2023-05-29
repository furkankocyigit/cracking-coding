namespace CrackingCodeTests.Chapters.BitManipulation
{
    [TestClass]
    public class BitManipulationTests
    {

        [DataTestMethod]
        [DataRow(128, 19, 2, 6, 204)]
        [DataRow(65, 12, 1, 4, 89)]
        [DataRow(2560, 7, 3, 5, 2616)]
        [DataRow(145, 10, 2, 5, 169)]
        public void insertValueTest(int source, int value, int startIndex, int endIndex, int expectedOutput)
        {
            int output = CrackingCoding.Chapters.BitManipulation.BitManipulation.insertValue(source, value, startIndex, endIndex);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
