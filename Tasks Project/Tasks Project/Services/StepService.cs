using System.Collections.Generic;
using System.Linq;
using Tasks_Project.Services.Interfaces;
using Tasks_Project.Models;
using Tasks_Project.Models.Data;

namespace Tasks_Project.Services
{
    public class StepService: IStepService
    {
        private MyContext context;

        public StepService(MyContext context)
        {
            this.context = context;
        }

       public int AddStep(Step step)
        {
            context.Steps.Add(step);
            context.Entry(step.Task).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.SaveChanges();
            return step.Id;
        }

        public int AddLittleStep(LittleStep littleStep)
        {
            context.LittleSteps.Add(littleStep);
            context.Entry(littleStep.Step).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
            context.SaveChanges();
            return littleStep.Id;
        }
        public List<Step> GetStepsForTask(int taskId)
        {
            return context.Steps.Where(x => x.Task.Id == taskId).ToList();
        }
        public List<LittleStep> GetLittleStepsForStep(int stepId)
        {
            return context.LittleSteps.Where(x => x.Step.Id == stepId).ToList();
        }
    }
}
