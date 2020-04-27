using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.application.Interfaces;
using WorkFlow.application.ViewModels;
using WorkFlow.Domain.Models;
using WorkFlow.Domain.Interfaces;

namespace WorkFlow.application.Services
{
    public class WorkFlowService : IWorkFlowService
    {
        IWorkFlowRepositoty _workFlowRepositoty;
        public WorkFlowService(IWorkFlowRepositoty _workFlowRepositoty)
        {
            this._workFlowRepositoty = _workFlowRepositoty;
        }
        public void AddWorkFlow(workFlow workFlow)
        {
            _workFlowRepositoty.AddWorkFlow(workFlow);

        }

        public WorkFlowViewModel GetAll()
        {
            return new WorkFlowViewModel()
            {
                workFlows = _workFlowRepositoty.GetAllWorkFlow()
            };
        }

        public WorkFlowViewModel GetAllApp()
        {
            return new WorkFlowViewModel()
            {
                applications = _workFlowRepositoty.GetAllApp()
            };
        }

        public WorkFlowViewModel getLastFiveElement()
        {
            return new WorkFlowViewModel()
            {
                workFlows = _workFlowRepositoty.getLastFiveElement()
            };
        }
    }
}
