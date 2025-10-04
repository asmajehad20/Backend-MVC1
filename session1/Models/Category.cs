using System.ComponentModel.DataAnnotations;

namespace session1.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
