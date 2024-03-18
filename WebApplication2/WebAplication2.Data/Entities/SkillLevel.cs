using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAplication2.Data.Entities.Abstractions;

namespace WebAplication2.Data.Entities
{
    public class SkillLevel : BaseEntity
    {
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public int SkillId { get; set; }
        public virtual Skill? Skill { get; set; }
        public int LevelId { get; set; }
        public virtual Level? Level { get; set; }
    }
}
