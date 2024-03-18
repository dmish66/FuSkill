using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAplication2.Data.Entities.Abstractions;

namespace WebAplication2.Data.Entities
{
    public class Skill : BaseEntity
    {
        public Skill()
        {
            Projects = new HashSet<Project>();
        }
        public string Name { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }

    }
}
