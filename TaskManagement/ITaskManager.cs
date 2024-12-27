using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
public interface ITaskManager
{
    void AddTask(Task task);
    List<Task> GetAllTasks();
}
}
