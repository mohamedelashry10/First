using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkFlow.application.ViewModels;
using WorkFlow.application.Interfaces;
using WorkFlow.Domain.Models;


namespace WorkFlow.Controllers
{
    public class WorkFlowController : Controller
    {
        IWorkFlowService _workFlowService;
        public WorkFlowController(IWorkFlowService _workFlowService)
        {
            this._workFlowService = _workFlowService;
        }
        
       
        public IActionResult Add()
        {
            WorkFlowViewModel AllApplication = _workFlowService.GetAllApp();
            ViewBag.ListOfApplication = AllApplication.applications.ToList();
            return PartialView("_add");
        }

        [HttpPost]
        public IActionResult Add(workFlow workFlow)
        {
            if (ModelState.IsValid)
            {
                _workFlowService.AddWorkFlow(workFlow);
                WorkFlowViewModel model = _workFlowService.getLastFiveElement();
                return PartialView("/Views/Home/_ListWorkFlow.cshtml", model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}