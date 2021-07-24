using System.Collections.Generic;
using System.Linq;
using Tasks_Project.Services.Interfaces;
using Tasks_Project.Models;
using Tasks_Project.Models.Data;
using Microsoft.EntityFrameworkCore;

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
        public int AddStepsRelation(StepsRelation stepsRelation)
        {
            context.StepsRelations.Add(stepsRelation);
            context.SaveChanges();
            return stepsRelation.Id;
        }
        public List<Step> GetStepsForTask(int taskId)
        {
            return context.Steps.Where(x => x.Task.Id == taskId).ToList();
        }
        public List<Step> GetLittleStepsForStep(int stepId)
        {
            List<StepsRelation> stepsRelations = new List<StepsRelation>();
            stepsRelations = context.StepsRelations.Where(x => x.BigStep.Id == stepId).Include(x => x.LittleStep).ToList();

            List<Step> littleSteps = new List<Step>();
            foreach(var stepsRelation in stepsRelations)
            {
                littleSteps.Add(GetStepById(stepsRelation.LittleStep.Id));
            }
            return littleSteps;
        }
        public Step GetStepById(int stepId)
        {
            return context.Steps.Where(x => x.Id == stepId).FirstOrDefault();
        }
    }
}
