namespace code_signal;

public class BinarySearchTree
{
    private Node root;

    private class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            this.Value = value;
            Right = null;
            Left = null;
        }
    }

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int value)
    {
        root = InsertNode(root, value);
    }

    private Node InsertNode(Node root, int value)
    {
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

        if (value < root.Value)
        {
            root.Left = InsertNode(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = InsertNode(root.Right, value);
        }

        return root;
    }

    public bool Search(int value)
    {
        return SearchNode(root, value);
    }

    private bool SearchNode(Node root, int value)
    {
        if (root == null || root.Value == value)
            return root != null;

        if (value < root.Value)
            return SearchNode(root.Left, value);
        else
            return SearchNode(root.Right, value);
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(root);
    }

    private void InOrderTraversal(Node root)
    {
        if (root != null)
        {
            InOrderTraversal(root.Left);
            Console.Write(root.Value + " ");
            InOrderTraversal(root.Right);
        }
    }
}
