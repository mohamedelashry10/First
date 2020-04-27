using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkFlow.Domain.Models
{
    public class workFlow
    {
        public workFlow()
        {
            Steps = new List<Step>();
            Instances = new List<Instance>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Applications")]
        public int ApplicationId { get; set; }
        public virtual Application Applications { get; set; }
        public virtual List<Step> Steps { get; set; }
        public virtual List<Instance> Instances { get; set; }
    }
}
