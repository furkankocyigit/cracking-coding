using CrackingCoding.Chapters.TreesAndGraphs;

namespace CrackingCodeTests.Chapters.TreesAndGraphs
{
    [TestClass]
    public class TreesAndGraphsTests
    {

        [TestMethod]
        public void binaryTreeFromArray()
        {
            int[] arr = new int[] { 1, 3, 6, 8, 10, 12, 14, 18, 22 };

            BinaryTree tree = BinaryHelper.createBinaryTreeFromArray(arr);

            Assert.AreEqual(10, tree.root.key);
            Assert.AreEqual(3, tree.root.left.key);
            Assert.AreEqual(14, tree.root.right.key);

            Assert.IsNull(tree.root.right.right.right.right);
            Assert.IsNull(tree.root.left.left.left);

        }
    }
}
