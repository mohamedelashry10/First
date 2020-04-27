using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.application.Interfaces;
using WorkFlow.application.ViewModels;
using WorkFlow.Domain.Interfaces;
using WorkFlow.Domain.Models;

namespace WorkFlow.application.Services
{
    public class ApplicationService : IApplicationService
    {
        IApplicationRepository _ApplicationRepository;
        public ApplicationService(IApplicationRepository _ApplicationRepository)
        {
            this._ApplicationRepository = _ApplicationRepository;
        }

        public void AddAppliction(Application application)
        {
            _ApplicationRepository.AddApplication(application);
           

        }

        public ApplicationViewModel GetAll()
        {
            return new ApplicationViewModel()
            {
                Applications = _ApplicationRepository.GetAllApplications()
            };
        }

        public ApplicationViewModel getLastFiveElement()
        {
            return new ApplicationViewModel()
            { 
                Applications = _ApplicationRepository.getLastFiveElement()
            };
        }
    }
}
