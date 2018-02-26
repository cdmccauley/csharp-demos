using System;

namespace BinaryTreeLibrary
{
    public class TreeNode
    {
        public TreeNode LeftNode { get; set; }

        public IComparable Data { get; set; }

        public TreeNode RightNode { get; set; }

        public TreeNode(IComparable nodeData)
        {
            Data = nodeData;
            LeftNode = RightNode = null;
        }

        public void Insert(IComparable insertValue)
        {
            if (insertValue.CompareTo(Data) < 0)
            {
                if (LeftNode == null)
                    LeftNode = new TreeNode(insertValue);
                else
                    LeftNode.Insert(insertValue);
            }
            else if (insertValue.CompareTo(Data) > 0)
            {
                if (RightNode == null)
                    RightNode = new TreeNode(insertValue);
                else
                    RightNode.Insert(insertValue);
            }
        }
    }

    public class Tree
    {
        private TreeNode root;

        public Tree()
        {
            root = null;
        }

        public void InsertNode(IComparable insertValue)
        {
            if (root == null)
                root = new TreeNode(insertValue);
            else
                root.Insert(insertValue);
        }

        public void PreorderTraversal()
        {
            PreorderHelper(root);
        }

        private void PreorderHelper(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");

                PreorderHelper(node.LeftNode);

                PreorderHelper(node.RightNode);
            }
        }

        public void InorderTraversal()
        {
            InorderHelper(root);
        }

        private void InorderHelper(TreeNode node)
        {
            if (node != null)
            {
                InorderHelper(node.LeftNode);

                Console.Write(node.Data + " ");

                InorderHelper(node.RightNode);
            }
        }

        public void PostOrderTraversal()
        {
            PostorderHelper(root);
        }

        private void PostorderHelper(TreeNode node)
        {
            if (node != null)
            {
                PostorderHelper(node.LeftNode);

                PostorderHelper(node.RightNode);

                Console.Write(node.Data + " ");
            }
        }
    }
}
