using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAplication2.Services.DTOs
{
    public class ProjectsDTO : BaseDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
    }
}
