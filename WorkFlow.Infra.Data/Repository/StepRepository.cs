using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkFlow.Domain.Interfaces;
using WorkFlow.Domain.Models;
using WorkFlow.Infra.Data.Context;
namespace WorkFlow.Infra.Data.Repository
{
    public class StepRepository : IStepReopsitory
    {
        WorkFlowDbContext Db;
        public StepRepository(WorkFlowDbContext Db)
        {
            this.Db = Db;
        }
        public void AddStep(Step step)
        {
            
            Db.Steps.Add(step);
            Db.SaveChanges();
        }

        public IEnumerable<workFlow> GerAllWorkFlow()
        {
            return Db.WorkFlows;
        }

        public IEnumerable<Step> GetAllSteps()
        {
            return Db.Steps.OrderBy(n=>n.WorkFlowId);
        }

        public IEnumerable<Step> getLastFiveElement()
        {
            return Db.Steps.Where(n=>n.IsFinalStep == true).OrderByDescending(n => n.Id).Take(5);
        }

        public Step GetLastStep(int workFlowId)
        {
            return Db.Steps.Where(n => n.WorkFlowId == workFlowId && n.StepOrder == getMaxNumberOfOrder(workFlowId)).FirstOrDefault();
        }

        public int getMaxNumberOfOrder(int workFlowId)
        {
            
            Step step = Db.Steps.Where(n => n.WorkFlowId == workFlowId).FirstOrDefault();
            if (step == null)
            {
                
                return 0;
            }
            else
                return Db.Steps.Where(n => n.WorkFlow.Id == workFlowId).Max(n => n.StepOrder);
        }

    }
}
