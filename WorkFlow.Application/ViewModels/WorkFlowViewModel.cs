using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkFlow.Domain.Models;
namespace WorkFlow.application.ViewModels
{
    public class WorkFlowViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ApplicationId { get; set; }
        public string Description { get; set; }
        public IEnumerable<workFlow> workFlows { get; set; }
        public IEnumerable<Application> applications { get; set; }

    }
}
