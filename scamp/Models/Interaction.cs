using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class Interaction {

        [Key] public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int OwnerFK { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostFK { get; set; }
        public Post Post { get; set; }
    }
}
