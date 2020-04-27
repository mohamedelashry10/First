using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.application.Interfaces;
using WorkFlow.application.ViewModels;
using WorkFlow.Domain.Models;

namespace WorkFlow.Controllers
{
    public class StepController : Controller
    {
        IStepService _stepService;
        public StepController(IStepService _stepService)
        {
            this._stepService = _stepService;
        }
     
        public IActionResult Add()
        {

            StepViewModel ListOfWorkFlow = _stepService.getAllWorkFlow();
            ViewBag.ListOfWorkFlow = ListOfWorkFlow.workFlows.ToList();

            return PartialView("_add");
        }
        [HttpPost]
        public IActionResult Add(Step step)
        {
            if (ModelState.IsValid)
            {
                
                StepViewModel modelStep = _stepService.getLastStep(step.WorkFlowId);
                if (modelStep.step != null)
                {
                    modelStep.step.IsFinalStep = false;
                }
                StepViewModel modelGetMax = _stepService.getMax(step.WorkFlowId);
                int LastNumberOfStepOrder = modelGetMax.StepOrder;
                step.StepOrder = LastNumberOfStepOrder + 1;
                _stepService.AddStep(step);

                StepViewModel model = _stepService.getLastFiveElement();
                return PartialView("/Views/Home/_ListStep.cshtml", model);
            }
            return RedirectToAction("Index", "Default");
        }
    }
}