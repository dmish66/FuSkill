using fuskill.Data.Entities.Abstractions;

namespace fuskill.Data.Entities
{
    public class Project : BaseEntity
    {
        public Project()
        {
            Skills = new HashSet<Skill>();
            Users = new HashSet<User>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public DateTime DueDate { get; set; }
        public virtual ICollection<Skill>? Skills { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
