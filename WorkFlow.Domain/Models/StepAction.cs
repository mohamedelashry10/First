using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class StepAction
    {
        public StepAction()
        {
            ActionOperators = new List<ActionOperator>();
        }
        public int Id { get; set; }
        [ForeignKey("Step")]
        public int StepId { get; set; }
        [ForeignKey("Action")]
        public int ActionId { get; set; }
        public virtual Step Step { get; set; }
        public virtual Action Action { get; set; }
        public virtual List<ActionOperator> ActionOperators { get; set; }

    }
}
