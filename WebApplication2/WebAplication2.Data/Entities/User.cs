using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAplication2.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            SkillLevels = new HashSet<SkillLevel>();
        }
        public virtual ICollection<SkillLevel>? SkillLevels { get; set; }
    }
}
