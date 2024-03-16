using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAplication2.Data.Entities.Abstractions;

namespace WebAplication2.Data.Entities
{
    public class Project : BaseEntity
    {
        public Project()
        {
            Skills = new HashSet<Skill>();
        }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public virtual ICollection<Skill>? Skills { get; set; }
    }
}
