namespace WebApplication2.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        // Additional properties
        public string FullName { get; set; }

        public string Bio { get; set; }

        // Relationships
        [InverseProperty("User")]
        public ICollection<UserSkill> UserSkills { get; set; }
    }
}
