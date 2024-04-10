using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Services.DTOs
{
    public class ProjectDTO: BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public DateTime DueDate { get; set; }
        public List<int> SkillsIds { get; set; }
    }
}
