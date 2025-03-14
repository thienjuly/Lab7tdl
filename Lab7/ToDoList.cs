using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public void DisplayTasks()
        {
            int i = 1;
            foreach (var task in tasks)
            {
                Console.WriteLine("{0}: {1}", i, task.GetDescription()); i++;
            }
        }
        public Task UpdateTask(int i, string updateDescription)
        {
            tasks[i].SetDescription(updateDescription);
            return tasks[i];
        }
        public void RemoveTask(int i)
        {
            tasks.RemoveAt(i);
        }
    }
}
