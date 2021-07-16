namespace DesignPatterns.Prototypes.Serialization
{
    public class BinaryTree
    {
        public Node Insert(Node root, int value)
        {
            if (root is null)
            {
                root = new Node(value);
                
            }
            else if (value < root.Value)
            {
                root.Left = Insert(root.Left, value);
            }
            else
            {
                root.Right = Insert(root.Right, value);
            }

            return root;
        }
    }
}