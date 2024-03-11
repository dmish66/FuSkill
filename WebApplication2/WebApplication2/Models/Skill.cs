namespace WebApplication2.Models

{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Skill
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Additional properties
        public string Description { get; set; }

        public string Category { get; set; }

        // Relationships
        [InverseProperty("Skill")]
        public ICollection<UserSkill> UserSkills { get; set; }
    }
}
