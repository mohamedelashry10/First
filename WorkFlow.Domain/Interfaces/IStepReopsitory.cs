using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Domain.Models;
namespace WorkFlow.Domain.Interfaces
{
    public interface IStepReopsitory
    {
        IEnumerable<Step> GetAllSteps();
        void AddStep(Step step);
        IEnumerable<workFlow> GerAllWorkFlow();
        int getMaxNumberOfOrder(int WorkFlowId );

        Step GetLastStep(int workFlowId );
        IEnumerable<Step> getLastFiveElement();

    }
}
