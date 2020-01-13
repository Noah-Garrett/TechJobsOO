using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.Views.Shared
{
    public class BaseViewModel
    {
        // View title
        public string Title { get; set; } = "";


        // All columns, for display
        public List<JobFieldType> Columns { get; set; }


        public BaseViewModel()
        {
        }
    }
}
