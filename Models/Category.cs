using System.ComponentModel.DataAnnotations;

namespace Dreams.Models
{
    public class Category
    {
        [Key] // data annotation (specifies this is a primary key)
        public int Id { get; set; } = 0;

        [Required, StringLength(300)]
        public string Name { get; set; } = String.Empty;

        [StringLength(1000)]
        public string? Description { get; set; } = String.Empty;
        
        // Relationship with Products and place to store products in the Department instance
        public virtual ICollection<CategoryProduct>? CategoryProducts { get; set; } = new List<CategoryProduct>();
    }
}