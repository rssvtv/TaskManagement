using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement;

namespace TaskManagement
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITaskManager taskManager = new TaskManager();

            // Пример добавления задачи
            Task newTask = new Task(0, "Изучить C#");
            taskManager.AddTask(newTask);

            // Пример получения всех задач
            List<Task> tasks = taskManager.GetAllTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Description: {task.Description}, Created: {task.CreatedDate}, Completed: {task.IsCompleted}");
            }
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }
        }
    }
}
