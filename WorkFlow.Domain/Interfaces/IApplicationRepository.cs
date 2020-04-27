using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Domain.Models;

namespace WorkFlow.Domain.Interfaces
{
   public interface IApplicationRepository
    {
        IEnumerable<Application> GetAllApplications();
        void AddApplication(Application _application);
        IEnumerable<Application> getLastFiveElement();
    }
}
