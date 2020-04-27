using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkFlow.Domain.Models;
namespace WorkFlow.application.ViewModels
{
   public class StepViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [DefaultValue(1)]
        public int StepOrder { get; set; }
        public IEnumerable<Step> steps { get; set; }
        public int WorkFlowId { get; set; }
        public IEnumerable<workFlow> workFlows { get; set; }
        public Step step { get; set; }
        
    }
}
