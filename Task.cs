using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Task
    {
        public string TaskName;
        public int ID;
        public string Description;
        public DateTime Date;
        public string Status;
        public Task Next;

        public Task(string taskName, int id, string description, DateTime date)
        {
            TaskName = taskName;
            ID = id;
            Description = description;
            Date = date;
            Status = "To Do"; 
            Next = null;
        }

        public override string ToString()
        {
            return $"[{ID}] {TaskName} - {Status} - {Date.ToShortDateString()}";
        }
    }
}
