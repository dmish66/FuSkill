using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace fuskill.Services.DTOs
{
    public class SkillDTO: BaseDTO
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }
}
