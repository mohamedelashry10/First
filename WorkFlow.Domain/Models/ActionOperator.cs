using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class ActionOperator
    {
        public int Id { get; set; }
        public int MustApproveToMoveNext { get; set; }
        [ForeignKey("Operator")]
        public int OperatorId { get; set; }
        [ForeignKey("StepAction")]
        public int StepActionId { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual StepAction StepAction { get; set; }
    }
}
