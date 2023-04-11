using CrackingCoding.Chapters.LinkedList;

namespace CrackingCodeTests.Chapters.LinkedList
{
    [TestClass]
    public class CustomLinkedListTests
    {
        private CustomLinkedList createSortedLinkedList(int lastElement)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            for (int i = 1; i <= lastElement; i++)
            {
                linkedList.Add(i);
            }
            return linkedList;
        }

        [DataTestMethod]
        [DataRow(1, 8)]
        [DataRow(3, 6)]
        [DataRow(5, 4)]
        [DataRow(8, 1)]
        public void getKthElementTest(int lastKthIndex, int expectedData)
        {
            CustomLinkedList linkedList = createSortedLinkedList(8);

            int data2 = linkedList.getLastKthElementAlternative(lastKthIndex);
            int data = linkedList.getLasthKthElement(lastKthIndex);




            Assert.AreEqual(expectedData, data);
            Assert.AreEqual(expectedData, data2);
        }

        [TestMethod]
        public void sumLinkedLists()
        {
            CustomLinkedList linkedList1 = createSortedLinkedList(3);  //123
            CustomLinkedList linkedList2 = createSortedLinkedList(4);  //1234
            bool reverseOrder = false;
            int sum = linkedList1.sumLinkListDigits(linkedList1, linkedList2, reverseOrder); // 123 +1234 = 1357
            Assert.AreEqual(1357, sum);

            reverseOrder = true;
            int sumReverse = linkedList1.sumLinkListDigits(linkedList1, linkedList2, reverseOrder); // 321 + 4321 = 4642
            Assert.AreEqual(4642, sumReverse);

        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 3, 2, 1 }, true)]
        [DataRow(new int[] { 1, 2, 2, 1 }, true)]
        [DataRow(new int[] { 1, 2, 3, 4, 3 }, false)]
        public void isPalindromeTest(int[] listElements, bool expectedResult)
        {
            CustomLinkedList list = new CustomLinkedList();
            foreach (int element in listElements)
            {
                list.Add(element);
            }

            bool palindrome = list.isPalindrom();

            Assert.AreEqual(expectedResult, palindrome);
        }


    }
}
