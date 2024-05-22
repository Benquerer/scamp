using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class Post {

		[Key] public int Id { get; set; }
		public DateTime DatePost { get; set; }

        [Required]
		public string PostText { get; set; }

        [ForeignKey(nameof(User))]
        public int UserFK { get; set; }
        public User User { get; set; }

    }
}
