using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class Action
    {
        public Action()
        {
            StepActions = new List<StepAction>();
            InstaneActions = new List<InstanceAction>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<StepAction> StepActions { get; set; }
        public virtual List<InstanceAction> InstaneActions { get; set; }
    }
}
