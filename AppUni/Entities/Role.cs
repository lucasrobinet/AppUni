using System.ComponentModel.DataAnnotations;

namespace AppUni.Entities
{
    public class Role: EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
