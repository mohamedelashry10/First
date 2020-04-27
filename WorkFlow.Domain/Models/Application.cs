using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class Application
    {
        public Application()
        {
            Operators = new List<Operator>();
            WorkFlows = new List<workFlow>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<Operator> Operators { get; set; }
        public virtual List<workFlow> WorkFlows { get; set; }
    }
}
