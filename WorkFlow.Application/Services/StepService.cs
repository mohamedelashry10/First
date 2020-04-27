using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.application.Interfaces;
using WorkFlow.application.ViewModels;
using WorkFlow.Domain.Models;
using WorkFlow.Domain.Interfaces;
namespace WorkFlow.application.Services
{
    public class StepService : IStepService
    {
        IStepReopsitory _stepReopsitory;
        public StepService(IStepReopsitory _stepReopsitory)
        {
            this._stepReopsitory = _stepReopsitory;
        }
        public void AddStep(Step step)
        {
            _stepReopsitory.AddStep(step);
        }

        public StepViewModel getAll()
        {
            return new StepViewModel()
            {
                steps = _stepReopsitory.GetAllSteps()
            };
        }

        public StepViewModel getAllWorkFlow()
        {
            return new StepViewModel()
            {
                workFlows = _stepReopsitory.GerAllWorkFlow()
            };
        }

        public StepViewModel getLastFiveElement()
        {
            return new StepViewModel()
            { 
                steps = _stepReopsitory.getLastFiveElement()
            };
        }

        public StepViewModel getLastStep(int workFlow)
        {
            return new StepViewModel()
            {
                step = _stepReopsitory.GetLastStep(workFlow)
            };
        }

        public StepViewModel getMax( int workFlowId)
        {
            return new StepViewModel()
            {
                StepOrder = _stepReopsitory.getMaxNumberOfOrder(workFlowId)
            };
        }
    }
}
