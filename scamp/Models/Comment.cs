using System.ComponentModel.DataAnnotations;

namespace scamp.Models
{
	public class Comment : Interaction {

        [Required]
        public string Commtxt { get; set; }
	}
}
