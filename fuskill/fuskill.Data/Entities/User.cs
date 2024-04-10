using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            Projects = new HashSet<Project>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SkillId { get; set; }
        public virtual Skill? Skill { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
    }
}
