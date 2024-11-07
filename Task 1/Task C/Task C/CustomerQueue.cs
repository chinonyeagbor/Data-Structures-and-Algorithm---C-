using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_C
{
    internal class CustomerQueue
    {
        public class Queue
        {
            private readonly int maxsize = 10;
            private Customer[] store;
            private int head = 0;
            private int tail = 0;
            private int numItems = 0;


            public Queue()
            {
                store = new Customer[maxsize];
            }

            public void Enqueue(Customer customer)
            {
                if (IsFull())
                {
                    MessageBox.Show("Queue is full");
                    return;
                }
                numItems++;
                store[tail] = customer;
                tail = (tail + 1) % maxsize;
            }

            public Customer Dequeue()
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is empty");
                }
                Customer customer = store[head];
                head = (head + 1) % maxsize;
                numItems--;
                return customer;
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
                for (int i = 0; i < numItems; i++)
                {
                    int index = (head + i) % maxsize;
                    contents.Append(store[index].GetCustomer() + Environment.NewLine);

                }

                return contents.ToString();
            }

            public void ReverseFirstK(int k)
            {
                if (k > numItems)
                {
                     MessageBox.Show("Enter a valid number.");
                     return;   
                }

                Customer[] temp = new Customer[k];
                for (int i = 0; i < k; i++)
                {
                    temp[k - i - 1] = store[(head + i) % maxsize];
                }

                for (int i = 0; i < k; i++)
                {
                    store[(head + i) % maxsize] = temp[i];
                }
            }

            public IEnumerable<Customer> GetCustomers()
            {
                for (int i = 0; i < numItems; i++)
                {
                    int index = (head + i) % maxsize;
                    yield return store[index];
                }
            }
        }
    }

}

