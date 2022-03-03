using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels
{
   public class ProjectViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}
