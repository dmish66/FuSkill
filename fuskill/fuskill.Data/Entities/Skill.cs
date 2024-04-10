using fuskill.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Data.Entities
{
    public class Skill: BaseEntity
    {
        public Skill() {
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
    