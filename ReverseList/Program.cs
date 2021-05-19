using System;

/*** 链表倒置 ***/
namespace ReverseList
{
    class Program
    {
        /// <summary>
        /// 内部类
        /// </summary>
        public class NodeList
        {
            public int val;
            public NodeList next;

            public NodeList(int val, NodeList next)
            {
                this.val = val;
                this.next = next;
            }
        }

        
        static void Main(string[] args)
        {
            try
            {
                NodeList node5 = new NodeList(5, null);
                NodeList node4 = new NodeList(4, node5);
                NodeList node3 = new NodeList(3, node4);
                NodeList node2 = new NodeList(2, node3);
                NodeList node1 = new NodeList(1, node2);

                NodeList newNodeList = Recursion(node1);
                    // Iterator(node1);
                Console.WriteLine(newNodeList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        
        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static NodeList Iterator(NodeList head)
        {
            NodeList next, prev = null;
            NodeList curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = null;
                prev = curr;
                curr = next;
            }
            return prev;
        }

        
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static NodeList Recursion(NodeList head)
        {
            if (head != null || head.next != null)
            {
                return head;
            }
            var newNodeList = Recursion(head.next);
            head.next.next = head;
            head.next = null;
            return newNodeList;
        }
    }
}