using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class InstanceAction
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserNumber { get; set; }
        [ForeignKey("Instance")]
        public int InstanceId { get; set; }
        [ForeignKey("Action")]
        public int ActionId { get; set; }
        [ForeignKey("Operator")]
        public int OperatorId { get; set; }
        [ForeignKey("Step")]
        public int StepId { get; set; }

        public virtual Instance Instance { get; set; }
        public virtual Action Action { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual Step Step { get; set; }
    }
}
