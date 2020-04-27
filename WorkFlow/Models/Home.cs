using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.application.ViewModels;

namespace WorkFlow.Models
{
    public class Home
    {
        public StepViewModel StepViewModel { get; set; }
        public ApplicationViewModel ApplicationViewModel { get; set; }
        public WorkFlowViewModel WorkFlowViewModel { get; set; }
    }
}
