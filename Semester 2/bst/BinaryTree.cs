using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeLibrary
{
    class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public int Data { get; set; }
        public TreeNode RightNode { get; set; }
        public TreeNode(int nodeData)
        {
            Data = nodeData;
            LeftNode = RightNode = null;
        }

        public void Insert(int insertValue)
        {
            if (insertValue < Data)
            {
                if (LeftNode == null)
                    LeftNode = new TreeNode(insertValue);
                else
                    LeftNode.Insert(insertValue);
            }
            else if (insertValue > Data)
            {
                if (RightNode == null)
                    RightNode = new TreeNode(insertValue);
                else
                    RightNode.Insert(insertValue);
            }
        }

        public class Tree
        {
            private TreeNode root;
            public Tree()
            {
                root = null;
            }

            public void InsertNode(int insertValue)
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

            public void PostorderTraversal()
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
}
