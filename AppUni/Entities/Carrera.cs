using System.ComponentModel.DataAnnotations;

namespace AppUni.Entities
{
    public class Carrera: EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
