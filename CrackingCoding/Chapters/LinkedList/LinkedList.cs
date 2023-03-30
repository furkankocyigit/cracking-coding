namespace CrackingCoding.Chapters.LinkedList
{
    public class Node
    {
        public Node? next;
        public int data;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class CustomLinkedList
    {
        public Node? head;
        public CustomLinkedList()
        {
            this.head = null;
        }

        public void Add(int data)
        {
            Node n = new Node(data);

            if (this.head == null)
            {
                this.head = n;
                return;
            }
            Node iterator = head;
            while (iterator != null)
            {
                if (iterator.next == null)
                {
                    iterator.next = n;
                    break;
                }
                iterator = iterator.next;
            }

        }
        public void invertList()
        {
            Node next = null;
            Node prev = null;
            Node current = head;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            head = prev;
        }

        public int getLasthKthElement(int index)
        {
            int returnData = -99999;
            this.invertList();

            Node iterator = this.head;
            int count = 1;
            while (iterator != null)
            {
                if (count == index)
                {
                    returnData = iterator.data;
                    break;
                }

                iterator = iterator.next;
                count++;

            }
            return returnData;

        }
        public int Length()
        {
            if (this.head == null) return 0;
            Node iterator = head;
            int length = 0;
            while (iterator != null)
            {
                iterator = iterator.next;
                length++;
            }
            return length;
        }
        public int getNumberFromDigits()
        {
            int list1Length = this.Length();
            Node listIterator = this.head;
            int sum = 0;
            while (listIterator != null)
            {
                sum += listIterator.data * (int)Math.Pow(10, list1Length - 1);
                listIterator = listIterator.next;
                list1Length--;
            }

            return sum;
        }

        public int getLastKthElementAlternative(int index)
        {
            Node iterator1 = head;
            Node iterator2 = head;

            for (int i = 0; i < index; i++)
            {
                if (iterator1 == null) return -999999;
                iterator1 = iterator1.next;

            }

            while (iterator1 != null)
            {
                iterator1 = iterator1.next;
                iterator2 = iterator2.next;
            }
            return iterator2.data;
        }

        public int sumLinkListDigits(CustomLinkedList list1, CustomLinkedList list2, bool reverseOrder)
        {
            if (list1 == null & list2 == null) return 0;
            if (reverseOrder)
            {
                list1.invertList();
                list2.invertList();
            }

            int list1Length = list1.Length();
            int list2Length = list2.Length();

            int number1 = list1.getNumberFromDigits();
            int number2 = list2.getNumberFromDigits();

            return number1 + number2;

        }


    }

}
