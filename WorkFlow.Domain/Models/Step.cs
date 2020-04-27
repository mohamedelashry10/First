using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class Step
    {
        public Step()
        {
            StepActions = new List<StepAction>();
            Instances = new List<Instance>();
            InstaneActions = new List<InstanceAction>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [DefaultValue(1)]
        public int StepOrder { get; set; }
        public bool IsFinalStep { get; set; } = true;
        [ForeignKey("WorkFlow")]
        public int WorkFlowId { get; set; }

        public virtual workFlow WorkFlow { get; set; }
        public virtual List<StepAction> StepActions { get; set; }
        public virtual List<Instance> Instances { get; set; }
        public virtual List<InstanceAction> InstaneActions { get; set; }
    }
}
