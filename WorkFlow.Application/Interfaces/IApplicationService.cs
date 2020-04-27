using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.application.ViewModels;
using WorkFlow.Domain.Models;

namespace WorkFlow.application.Interfaces
{
   public interface IApplicationService
    {
        ApplicationViewModel GetAll();
        void AddAppliction(Application application );
        ApplicationViewModel getLastFiveElement();

    }
}
