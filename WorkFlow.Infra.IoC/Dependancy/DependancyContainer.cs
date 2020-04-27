using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WorkFlow.Domain.Interfaces;
using WorkFlow.application.Interfaces;
using WorkFlow.application.Services;
using WorkFlow.Infra.Data.Repository;

namespace WorkFlow.Infra.IoC.WorkFlow.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IWorkFlowRepositoty, WorkFlowRepository>();
            services.AddScoped<IWorkFlowService, WorkFlowService>();
            services.AddScoped<IStepReopsitory, StepRepository>();
            services.AddScoped<IStepService, StepService>();
        }
    }
}
