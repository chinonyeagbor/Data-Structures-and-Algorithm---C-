using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskB
{
    internal class CustomerQueue
    {
        public class Queue
        {
            private readonly int maxsize = 20;
            private string[] store;
            private int head = 0;
            private int tail = 0;
            private int numItems = 0;


            public Queue()
            {
                store = new string[maxsize];
            }

            public void Enqueue(string name)
            {
                if (IsFull())
                {
                    MessageBox.Show("Queue is full");
                }
                numItems++;
                store[tail] = name;
                tail = (tail + 1) % maxsize;
            }

            public string Dequeue()
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is empty");
                }
                string name = store[head];
                head = (head + 1) % maxsize;
                numItems--;
                return name;
            }

            public string Peek()
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is empty");
                }
                return store[head];
            }

            public bool IsEmpty()
            {
                return numItems == 0;
            }

            public bool IsFull()
            {
                return numItems == maxsize;
            }
            public int Count()
            {
            return numItems;
            }

            public string GetContents()
            {
                StringBuilder contents = new StringBuilder();
                for (int i= 0; i < maxsize; i++)
                {
                    int index = (head + i) % maxsize;
                    contents.Append(store[index] + Environment.NewLine);
                    
                }

                return contents.ToString();
            }
        }
  
    }
}
