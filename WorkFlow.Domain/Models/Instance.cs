using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class Instance
    {
        public Instance()
        {
            InstaneActions = new List<InstanceAction>();
        }
        public int Id { get; set; }
        public int InstanceNumber { get; set; }
        public bool IsClosed { get; set; }
        [ForeignKey("WorkFlow")]
        public int WorkFlowId { get; set; }
        [ForeignKey("Step")]
        public int CurrentStepId { get; set; }

        public virtual workFlow WorkFlow { get; set; }
        public virtual Step Step { get; set; }
        public virtual List<InstanceAction> InstaneActions { get; set; }
    }
}
