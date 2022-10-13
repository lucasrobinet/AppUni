using System.ComponentModel.DataAnnotations;

namespace AppUni.Entities
{
    public class Facultad: EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int TotalUsers { get; set; }
    }
}
