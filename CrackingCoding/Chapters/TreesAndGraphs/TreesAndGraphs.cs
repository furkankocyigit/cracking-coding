namespace CrackingCoding.Chapters.TreesAndGraphs
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        // Root of Binary Tree
        public Node root;

        public BinaryTree() { root = null; }

        /* Given a binary tree, print
           its nodes in inorder*/
        void printInorder(Node node)
        {
            if (node == null)
                return;
            /* then print the data of node */

            /* first recur on left child */
            printInorder(node.left);


            /* now recur on right child */
            printInorder(node.right);

            Console.Write(node.key + " ");

        }
        void printInorder() { printInorder(root); }


    }

    public static class BinaryHelper
    {
        public static BinaryTree createBinaryTreeFromArray(int[] arr)
        {
            int depth = findMinDepth(arr.Length);
            BinaryTree tree = new BinaryTree();

            tree.root = construct(arr, 0, arr.Length - 1);
            return tree;
        }

        private static Node construct(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }
            int mid = (startIndex + endIndex) / 2;
            Node node = new Node(arr[mid]);
            node.left = construct(arr, startIndex, mid - 1);
            node.right = construct(arr, mid + 1, endIndex);

            return node;
        }

        private static int findMinDepth(int length)
        {
            int depth = 0;
            for (int i = 0; i < length; i++)
            {
                if (Math.Pow(2, i) - 1 >= length)
                {
                    depth = i - 1;
                    break;
                };
            }
            return depth;
        }
    }
}