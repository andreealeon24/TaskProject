using System;
using System.Collections.Generic;
using System.Linq;
using Tasks_Project.Models;
using Tasks_Project.Models.Data;

namespace Tasks_Project.Services.Interfaces
{
    public interface IStepService
    {
        int AddStep(Step step);
        int AddStepsRelation(StepsRelation stepsRelation);
        List<Step> GetStepsForTask(int taskId);
        List<Step> GetLittleStepsForStep(int stepId);
        Step GetStepById(int stepId);
    }
}
