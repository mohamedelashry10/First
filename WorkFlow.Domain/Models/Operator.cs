using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class Operator
    {
        public Operator()
        {
            ActionOperators = new List<ActionOperator>();
            InstaneActions = new List<InstanceAction>();
        }
        public int Id { get; set; }
        public int OperatorNumber { get; set; }
        [ForeignKey("OperatorTypes")]
        public int OperatorTypeId { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }

        public virtual Application Applications { get; set; }
        public virtual OperatorTypes OperatorTypes { get; set; }
        public virtual List<ActionOperator> ActionOperators { get; set; }
        public virtual List<InstanceAction> InstaneActions { get; set; }


    }
}
