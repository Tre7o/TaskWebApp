using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskWebApp.Models;

namespace TaskWebApp.Services.Data
{
    public class TaskService
    {
        TaskRepo taskRepo = new TaskRepo();

        public bool AddTaskService(Task task)
        {
            return taskRepo.SaveTask(task);
        }
    }
}