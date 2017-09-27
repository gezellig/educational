namespace DotNet
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class Bst
    {
        Node _root;
        static int _count;

        public Bst()
        { 
            _root = null;
            _count = 0;
        }

        public Node AddNode(int data)
        {
            var newNode = new Node(data);
            if (_root == null)
            {
                _root = newNode;
            }
            else if (data < _root.Data)
            {
                newNode.Left = new Node(data);
            }
            else newNode.Right = new Node(data);
            _count++;
            return _root;
        }
    }
}