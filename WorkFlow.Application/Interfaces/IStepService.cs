using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Domain.Models;
using WorkFlow.application.ViewModels;
namespace WorkFlow.application.Interfaces
{
   public interface IStepService
    {
        
        StepViewModel getAll();
        void AddStep(Step step);
        StepViewModel getAllWorkFlow();
        StepViewModel getMax(int WorkFlowId);
        StepViewModel getLastStep(int workFlow);
        StepViewModel getLastFiveElement();
    }
}
