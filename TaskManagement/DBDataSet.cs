using System;
using System.Data;

namespace TaskManagement
{
    public partial class DBDataSet : DataSet
    {
        public DataTable Tasks { get; private set; } // Сделаем свойство только для чтения

        public DBDataSet()
        {
            Tasks = new DataTable("Tasks");
            // Добавляем колонки в DataTable
            Tasks.Columns.Add("TaskID", typeof(int));
            Tasks.Columns.Add("TaskNumber", typeof(string));
            Tasks.Columns.Add("Description", typeof(string));
            Tasks.Columns.Add("Priority", typeof(string));
            Tasks.Columns.Add("AssigneeID", typeof(int));
            Tasks.Columns.Add("Status", typeof(string));

            // Устанавливаем первичный ключ
            Tasks.PrimaryKey = new DataColumn[] { Tasks.Columns["TaskID"] };
        }

        // Метод для добавления новой задачи
        public void AddTask(int taskId, string taskNumber, string description, string priority, int assigneeId, string status)
        {
            DataRow newRow = Tasks.NewRow();
            newRow["TaskID"] = taskId;
            newRow["TaskNumber"] = taskNumber;
            newRow["Description"] = description;
            newRow["Priority"] = priority;
            newRow["AssigneeID"] = assigneeId;
            newRow["Status"] = status;
            Tasks.Rows.Add(newRow);
        }

        // Метод для получения всех задач
        public DataTable GetAllTasks()
        {
            return Tasks;
        }

        // Метод для поиска задачи по TaskID
        public DataRow FindTaskById(int taskId)
        {
            return Tasks.Rows.Find(taskId);
        }

        public void SomeMethod()
        {
            throw new NotImplementedException();
        }
    }
}


