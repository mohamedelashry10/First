using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WorkFlow.Domain.Models;

namespace WorkFlow.application.ViewModels
{
    public class ApplicationViewModel
    {
        public IEnumerable <Application> Applications { get; set; }
        //public Application Application { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
