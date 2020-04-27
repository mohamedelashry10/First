using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkFlow.Domain.Interfaces;
using WorkFlow.Domain.Models;
using WorkFlow.Infra.Data.Context;
namespace WorkFlow.Infra.Data.Repository
{
    public class WorkFlowRepository : IWorkFlowRepositoty
    {
        WorkFlowDbContext db;
        public WorkFlowRepository(WorkFlowDbContext db)
        {
            this.db = db;
        }

        public void AddWorkFlow(workFlow workFlow)
        {

            db.WorkFlows.Add(workFlow);
            db.SaveChanges();
        }

        public IEnumerable<Application> GetAllApp()
        {
            return db.Applications;
        }

        public IEnumerable<workFlow> GetAllWorkFlow()
        {
            return db.WorkFlows;
        }

        public IEnumerable<workFlow> getLastFiveElement()
        {
            return db.WorkFlows.OrderByDescending(n => n.Id).Take(5);
        }
    }
}
