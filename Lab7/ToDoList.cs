using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class ToDoList
    {
        List<Task> tasks = new List<Task>();
        public void insertTask(Task task)
        {
            tasks.Add(task);
        }
        public void displayTask()
        {
            int i = 1;
            foreach (var task in tasks)
            {
                Console.WriteLine(i + ": ");
                Console.WriteLine(task.getDescription()); i++;
            }
        }
    }
}
