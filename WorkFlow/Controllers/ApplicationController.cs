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
    public class ApplicationController : Controller
    {
        IApplicationService _applicationService;
        public ApplicationController(IApplicationService _applicationService)
        {
            this._applicationService = _applicationService;
        }
        
        public IActionResult Add()
        {

            return PartialView("_Add");
        }
        [HttpPost]
        public IActionResult Add(Application application)
        {
            if (ModelState.IsValid) 
            { 
                _applicationService.AddAppliction(application);
                ApplicationViewModel model = _applicationService.getLastFiveElement();
                return PartialView("/Views/Home/_ListApplication.cshtml", model);
            }
            return RedirectToAction("Index", "Home");
        }


    }
}