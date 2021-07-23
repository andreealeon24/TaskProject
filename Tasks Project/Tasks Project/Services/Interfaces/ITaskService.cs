using System;
using System.Collections.Generic;
using System.Linq;
using Tasks_Project.Models;

namespace Tasks_Project.Services.Interfaces
{
    public interface ITaskService
    {
        int AddTask(Task task);
        List<Task> GetTasks();
    }
}
