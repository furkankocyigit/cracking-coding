using CrackingCoding.Chapters.StackAndQueue;

namespace CrackingCodeTests.Chapters.StackAndQueue
{
    [TestClass]
    public class CustomStackTest
    {
        [TestMethod]
        public void peekTest()
        {
            CustomStack stack = new CustomStack();
            stack.push(1);
            stack.push(2);
            stack.push(3);

            Assert.AreEqual(3, stack.peek());
        }

        [TestMethod]
        public void popTest()
        {
            CustomStack stack = new CustomStack();

            stack.push(1);
            stack.push(2);
            stack.push(3);

            Assert.AreEqual(3, stack.pop());
            Assert.AreEqual(2, stack.peek());
        }

        [TestMethod]
        public void minimumTest()
        {
            CustomStack stack = new CustomStack();

            stack.push(2);
            stack.push(3);
            stack.push(1);
            stack.push(4);
            stack.push(5);

            Assert.AreEqual(1, stack.min());
        }


        [TestMethod]
        public void sortTest()
        {
            CustomStack stack = new CustomStack();

            stack.push(1);
            stack.push(3);
            stack.push(5);
            stack.push(2);
            stack.push(4);
            stack.push(6);

            CustomStack sortedStack = stack.sort();

            Assert.AreEqual(1, sortedStack.peek());
            Assert.AreEqual(1, sortedStack.pop());
            Assert.AreEqual(2, sortedStack.peek());
            Assert.AreEqual(2, sortedStack.pop());
            Assert.AreEqual(3, sortedStack.peek());
            Assert.AreEqual(3, sortedStack.pop());
            Assert.AreEqual(4, sortedStack.peek());
            Assert.AreEqual(4, sortedStack.pop());
        }


    }
}
