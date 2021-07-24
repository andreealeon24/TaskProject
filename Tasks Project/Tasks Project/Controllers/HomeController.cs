using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Tasks_Project.Models;
using Tasks_Project.Models.Data;
using Tasks_Project.Services.Interfaces;

namespace Tasks_Project.Controllers
{
    public class HomeController : Controller
    {
        private ITaskService taskService;
        private IStepService stepService;

        public HomeController(ITaskService taskService, IStepService stepService)
        {
           this.taskService = taskService;
           this.stepService = stepService;
        }

        public IActionResult Index()
        {
            List<Task> tasks = new List<Task>();
            tasks = taskService.GetTasks();

            foreach(var task in tasks)
            {
                List<Step> steps = new List<Step>();
                steps = stepService.GetStepsForTask(task.Id);
                

                foreach(var step in steps)
                {
                        List<Step> littleSteps = new List<Step>();
                        littleSteps = stepService.GetLittleStepsForStep(step.Id);
                        step.LittleSteps = littleSteps;
                }
                List<Step> bigSteps = new List<Step>();
                foreach (var step in steps)
                {
                    if (!step.IsLittleStep)
                    {
                        bigSteps.Add(step);
                    }
                }
                task.Steps = bigSteps;
            }

            return View(tasks);
        }

        public IActionResult LazyLoaded()
        {
            List<Task> tasks = new List<Task>();
            tasks = taskService.GetTasks();

            foreach (var task in tasks)
            {
                List<Step> steps = new List<Step>();
                steps = stepService.GetStepsForTask(task.Id);


                foreach (var step in steps)
                {
                    List<Step> littleSteps = new List<Step>();
                    littleSteps = stepService.GetLittleStepsForStep(step.Id);
                    step.LittleSteps = littleSteps;
                }
                List<Step> bigSteps = new List<Step>();
                foreach (var step in steps)
                {
                    if (!step.IsLittleStep)
                    {
                        bigSteps.Add(step);
                    }
                }
                task.Steps = bigSteps;
            }
            return View(tasks);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
