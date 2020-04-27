using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorkFlow.Models;
using WorkFlow.application.ViewModels;
using WorkFlow.application.Interfaces;
namespace WorkFlow.Controllers
{
    public class HomeController : Controller
    {
        IStepService _stepService;
        IWorkFlowService _WorkFlowService;
        IApplicationService _applicationService;
        public HomeController(IStepService _stepService,IWorkFlowService _WorkFlowService,IApplicationService _applicationService)
        {
            this._stepService = _stepService;
            this._WorkFlowService = _WorkFlowService;
            this._applicationService = _applicationService;
        }
        public IActionResult Index()
        {
            StepViewModel allSteps = _stepService.getLastFiveElement();
            WorkFlowViewModel allWorkFlows = _WorkFlowService.getLastFiveElement();
            ApplicationViewModel allApplication = _applicationService.getLastFiveElement();
            Home model = new Home() { ApplicationViewModel = allApplication , WorkFlowViewModel = allWorkFlows , StepViewModel = allSteps };
            return View(model);
        }

    }
}
