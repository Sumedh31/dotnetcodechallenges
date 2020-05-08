using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProblems.Trees
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    class BinaryTreeIterativeTraversal
    {
        public Node root;
        public static void Init()
        {
            BinaryTreeIterativeTraversal tree = new BinaryTreeIterativeTraversal();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            IterativeInorder(tree.root);
            
        }
        private static void IterativeInorder(Node root)
        {
            Stack<Node> maintainer = new Stack<Node>();
            Node current = root;
            int[] arr1 = { };
          
            while(true)
            {
                if(current!=null)
                {
                    maintainer.Push(current);
                    current = current.left;
                }
                else if(maintainer.Count>0)
                {                    
                    current = maintainer.Pop(); 
                    Console.WriteLine(current.data + " ");
                    //if (current.right == null)
                    //    current = null;
                    //else
                    current = current.right;
                }
                else
                {
                    Console.ReadLine();
                    break;
                }
                        
            }
        }
    }
}
