using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class ToDoList
    {
        public Task Head;

        public void InsertInOrder(Task task)
        {
            if (Head == null || task.Date < Head.Date)
            {
                task.Next = Head;
                Head = task;
            }
            else
            {
                Task current = Head;
                while (current.Next != null && current.Next.Date <= task.Date)
                {
                    current = current.Next;
                }
                task.Next = current.Next;
                current.Next = task;
            }
        }

       
        public Task RemoveById(int id)
        {
            Task current = Head, prev = null;

            while (current != null)
            {
                if (current.ID == id)
                {
                    if (prev == null)
                        Head = current.Next;
                    else
                        prev.Next = current.Next;

                    current.Next = null;
                    return current;
                }
                prev = current;
                current = current.Next;
            }
            return null;
        }

        public void Display()
        {
            Task current = Head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}
