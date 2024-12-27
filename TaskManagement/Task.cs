using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCompleted { get; set; }
        public Task(int id, string description)
        {
            Id = id;
            Description = description;
            CreatedDate = DateTime.Now;
            IsCompleted = false;
        }
    }
}
   

