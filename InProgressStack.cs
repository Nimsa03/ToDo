using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class InProgressStack
    {
       
        public Task Top;

        public void Push(Task task)
        {
            task.Next = Top;
            Top = task;
        }

        public Task Pop()
        {
            if (Top == null) return null;
            Task task = Top;
            Top = Top.Next;
            task.Next = null;
            return task;
        }

        public void Display()
        {
            Task current = Top;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}
