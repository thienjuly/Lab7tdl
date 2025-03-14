namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList list1 = new ToDoList();
            Task task1 = new Task("Go to school");
            Task task2 = new Task("Go back home");
            list1.insertTask(task1);
            list1.insertTask(task2);
            list1.DisplayTasks();
            Console.WriteLine("============");

            list1.UpdateTask(0, "wake up");
            list1.DisplayTasks();
            Console.WriteLine("============");

            list1.RemoveTask(1);
            list1.DisplayTasks();
            Console.WriteLine("=============");
        }
    }
}
