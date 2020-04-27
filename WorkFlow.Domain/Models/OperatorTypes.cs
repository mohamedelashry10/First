using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class OperatorTypes
    {
        public OperatorTypes()
        {
            Operators = new List<Operator>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Operator> Operators { get; set; }
    }
}
