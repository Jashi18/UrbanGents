using System.ComponentModel.DataAnnotations;

namespace UrbanGents.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
