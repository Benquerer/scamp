using System.ComponentModel.DataAnnotations;

namespace scamp.Models
{
	public class Course {

        [Key] public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Abrev { get; set; }

        public string Color { get; set; }

        public string Logo { get; set; }


    }
}
