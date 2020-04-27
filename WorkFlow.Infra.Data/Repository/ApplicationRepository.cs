using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkFlow.Domain.Interfaces;
using WorkFlow.Domain.Models;
using WorkFlow.Infra.Data.Context;

namespace WorkFlow.Infra.Data.Repository
{
  public  class ApplicationRepository : IApplicationRepository
    {
        WorkFlowDbContext DB;
        public ApplicationRepository( WorkFlowDbContext DB)
        {
            this.DB = DB;
        }

        //public  Application AddApplication(Application _application)
        //{
        //        DB.Applications.Add(_application)
        //}

        public IEnumerable<Application> GetAllApplications()
        {
            return DB.Applications;
        }

        public IEnumerable<Application> getLastFiveElement()
        {
            return DB.Applications.OrderByDescending(n => n.Id).Take(5);
        }

        void IApplicationRepository.AddApplication(Application _application)
        {
            
            DB.Applications.Add(_application);
            DB.SaveChanges();
        }
    }
}
