using System;

namespace repeated_list
{
    class LinkedList
    {
        static Node head;

        /* Link list node */
        public class Node
        {
            public int data;
            public Node next;
        };

        
        static int majority(Node head)
        {
            Node p = head;

            int total_count = 0,
                max_count = 0, res = -1;
            while (p != null)
            {

                
                int count = 1;
                Node q = p.next;
                while (q != null)
                {
                    if (p.data == q.data)
                        count++;
                    q = q.next;
                }

               
                if (count >= max_count) 
                {
                    max_count = count;
                    res = p.data;
                }

                p = p.next;
                total_count++;
            }

            if (Math.Abs(total_count) > max_count / 2)
                return res;

            
            return -9999999;
        }

        static void push(Node head_ref,
                         int new_data)
        {
            Node new_node = new Node();
            new_node.data = new_data;
            new_node.next = head_ref;
            head_ref = new_node;
            head = head_ref;
        }

        
        public static void Main(String[] args)
        {

            
            head = null;
            Console.WriteLine("Write size for array");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            Console.WriteLine("Add List:");
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                push(head, a);
            }

            int res = majority(head);

            if (res != (-9999999))
                Console.WriteLine("Majority element is " + res);
        }
    }
}
