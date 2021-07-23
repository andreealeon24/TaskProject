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
        int AddLittleStep(LittleStep littleStep);
        List<Step> GetStepsForTask(int taskId);
        List<LittleStep> GetLittleStepsForStep(int stepId);
    }
}
