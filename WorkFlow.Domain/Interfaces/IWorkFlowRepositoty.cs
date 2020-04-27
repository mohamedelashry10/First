using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Domain.Models;
namespace WorkFlow.Domain.Interfaces
{
   public interface IWorkFlowRepositoty
    {
        IEnumerable<workFlow> GetAllWorkFlow();
        void AddWorkFlow(workFlow workFlow);
        IEnumerable<Application> GetAllApp();
        IEnumerable<workFlow> getLastFiveElement();

    }
}
