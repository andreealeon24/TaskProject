using System.Collections.Generic;
using System.Linq;
using Tasks_Project.Services.Interfaces;
using Tasks_Project.Models;

namespace Tasks_Project.Services
{
    public class TaskService: ITaskService
    {
        private MyContext context;
        public TaskService(MyContext context)
        {
            this.context = context;
        }

        public int AddTask(Task task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
            return task.Id;
        }

        public List<Task> GetTasks()
        {
            return context.Tasks.ToList();
        }
    }
}
