namespace CrackingCoding.Chapters.StackAndQueue
{


    public class CustomStack
    {

        public class StackNode
        {
            public int data;
            public StackNode? next;
            public StackNode(int data)
            {
                this.data = data;
            }
        }

        private StackNode? top;
        private int minimum;

        public CustomStack()
        {
            minimum = int.MaxValue;
        }

        public int pop()
        {
            if (top == null) throw new InvalidOperationException();

            int item = top.data;
            top = top.next;
            return item;
        }

        public void push(int item)
        {
            if (item.CompareTo(minimum) <= 0)
            {
                minimum = item;
            }
            StackNode node = new StackNode(item);
            node.next = top;
            top = node;

        }

        public int peek()
        {
            if (top != null)
            {
                return top.data;
            }
            throw new Exception("Stack is empty!");
        }
        public bool isEmpty()
        {
            return top == null;
        }

        public int min()
        {
            return minimum;
        }

        public CustomStack sort()
        {
            CustomStack sortedStack = new CustomStack();

            StackNode current = top;
            StackNode current2;
            StackNode prev = null;
            while (current != null)
            {
                StackNode node = new StackNode(current.data);
                if (sortedStack.isEmpty())
                {
                    sortedStack.top = node;
                    prev = sortedStack.top;
                }

                current2 = sortedStack.top;
                while (current2 != null)
                {
                    if (current.data < sortedStack.top.data)
                    {
                        sortedStack.push(node.data);
                        break;
                    }
                    if (current.data < current2.data)
                    {
                        node.next = current2;
                        prev.next = node;
                        break;
                    }
                    prev = current2;
                    current2 = current2.next;
                }

                current = current.next;

            }

            return sortedStack;
        }
    }
}
