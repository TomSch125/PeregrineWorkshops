using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {

        private Node head = null;
        private int size = 0;

        public int Size() {
            return size;
        }

        public bool IsEmpty() {
            return size == 0;
        }

        public int Peek() {
            if (IsEmpty()) {
                throw new System.InvalidOperationException("EmptyListException");
            }
            return head.value;
        }

        public void AddHead(int value) {
            this.head = new Node(value, head);
            size++;
        }

        public void AddTail(int value) {
            Node newNode = new Node(value, null);
            Node cur = head;

            if (head == null) {
                head = newNode;
            }

            while (cur.next != null) {
                cur = cur.next;
            }

            cur.next = newNode;
            size++;

        }

        public int RemoveHead() {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }
            int val = head.value;
            head = head.next;
            size--;
            return val;
        }

        public bool Search(int data) {
            Node temp = head;
            while (temp != null) {
                if (temp.value == data) {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public bool DeleteNode(int deldata) {
            Node temp = head;

            if (IsEmpty()) {
                return false;
            }

            if (deldata == head.value) {
                head = head.next;
                size--;
                return true;
            }
            while (temp.next != null) {
                if (temp.next.value == deldata) {
                    temp.next = temp.next.next;
                    size--;
                    return true;
                }
                temp = temp.next;

            }
            return false;

        }

        public void Reverse() {
            Node curr = head;
            Node prev = null;
            Node next = null;

            while (curr != null) {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public int FindLength() {
            Node curr = head;
            int count = 0;
            while (curr != null) {
                count++;
                curr = curr.next;
            }

            return count;

        }

        public void Print() {
            Node temp = head;
            while (temp != null) { 
                Console.Write(temp.value+" ");
                temp = temp.next;
            }
            Console.WriteLine("");
        
        }

        public void RemoveDuplicate()
        {
            Dictionary<int,int> seen = new Dictionary<int, int>();

            if (head == null || head.next == null) {
                return;
            }
            int count = 0;
            Node curr = head;
            Node last = null;
            while (curr != null)
            {
                if (seen.ContainsKey(curr.value)) {
                    last.next = curr.next;
                    size--;
                }
                else { 
                    seen.Add(curr.value, count);
                    last = curr;
                    count++;
                }
                curr = curr.next;
            }

            return;
        }

        public void BubbleSort() {
            Node curr = head;
            Node temp = null;
            Node tempNext = null;
            Node last;

            int swaps = 1;
            while (swaps != 0)
            {
                swaps = 0;
                curr = head;
                last = null;
                while (curr != null) {
                    if (curr.next != null) {
                        if (curr.value > curr.next.value)
                        {
                            if (curr == head) {
                                head = curr.next;
                            }
                            tempNext = curr.next.next;
                            temp = curr;
                            curr = curr.next;
                            curr.next = temp;
                            curr.next.next = tempNext;
                            if (last != null) { last.next = curr; }
                          
                            swaps++;

                        }
                    }
                    last = curr;
                    curr = curr.next;
                }
            }
        }

        public int NthNodeFromBeginning(int i) {
            if (i > size - 1) {
                if (IsEmpty())
                {
                    throw new System.InvalidOperationException("IndexOutOfBounds");
                }
            }
            int i_cur = 0;
            Node curr = head;
            int val = -1;
            while (curr != null)
            {
                if (i == i_cur) {
                    val = curr.value;
                    break;
                }
                i_cur++;
                curr = curr.next;
            }
            return val;
        }

        public int NthNodeFromEnd(int i)
        {
            int index = size - 1 - i;
            if (index < 0)
            {
                if (IsEmpty())
                {
                    throw new System.InvalidOperationException("IndexOutOfBounds");
                }
            }
            int i_cur = 0;
            Node curr = head;
            int val = -1;
            while (curr != null)
            {
                if (index == i_cur)
                {
                    val = curr.value;
                    break;
                }
                i_cur++;
                curr = curr.next;
            }
            return val;
        }
    }
}
