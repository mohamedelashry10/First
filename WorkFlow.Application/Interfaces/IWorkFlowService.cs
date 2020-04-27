using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.application.ViewModels;
using WorkFlow.Domain.Models;
namespace WorkFlow.application.Interfaces
{
  public interface IWorkFlowService
    {
        WorkFlowViewModel GetAll();
        void AddWorkFlow(workFlow workFlow);
        WorkFlowViewModel GetAllApp();
        WorkFlowViewModel getLastFiveElement();
    }
}
