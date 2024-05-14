using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class Interacao {

        [Key] public int id { get; set; }
        [ForeignKey(nameof(Utilizador))]
        public int ownerId { get; set; }
        public Utilizador utilizador { get; set; }

        [ForeignKey(nameof(Post))]
        public int postId { get; set; }
        public Post post { get; set; }
    }
}
