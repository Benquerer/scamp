using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class Interacao {

		public int iid { get; set; }


        [ForeignKey(nameof(Utilizador))]
        public int ownerId { get; set; }
        public Utilizador utilizadores { get; set; }

        [ForeignKey(nameof(Post))]
        public int postId { get; set; }
        public Post post { get; set; }
    }
}
