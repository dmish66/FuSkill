namespace WebApplication2.Models
{
    public class UserSkill
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        // Additional properties
        public int ExperienceYears { get; set; }
    }
}
