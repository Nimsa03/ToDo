using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class CompletedQueue
    {
        private Task front, rear;

        public void Enqueue(Task task)
        {
            if (rear == null)
            {
                front = rear = task;
            }
            else
            {
                rear.Next = task;
                rear = task;
            }
        }

        public void Display()
        {
            Task current = front;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}
