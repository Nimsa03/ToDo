using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class TaskManager
    {
        
        ToDoList toDoList = new ToDoList();
        InProgressStack inProgressStack = new InProgressStack();
        CompletedQueue completedQueue = new CompletedQueue();

        public void AddTask(Task task)
        {
            toDoList.InsertInOrder(task);
        }

        public void ChangeStatusToInProgress(int id)
        {
            Task task = toDoList.RemoveById(id);
            if (task != null)
            {
                task.Status = "In Progress";
                inProgressStack.Push(task);
            }
            else
            {
                Console.WriteLine("Task not found in To-Do list.");
            }
        }

        public void ChangeStatusToCompleted()
        {
            Task task = inProgressStack.Pop();
            if (task != null)
            {
                task.Status = "Completed";
                completedQueue.Enqueue(task);
            }
            else
            {
                Console.WriteLine("No tasks in progress.");
            }
        }

        public void ShowAllLists()
        {
            Console.WriteLine("\n=== TO-DO ===");
            toDoList.Display();
            Console.WriteLine("\n=== IN-PROGRESS ===");
            inProgressStack.Display();
            Console.WriteLine("\n=== COMPLETED ===");
            completedQueue.Display();
        }
    }
}
