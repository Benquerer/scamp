using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class Post {

		public int pid { get; set; }

		public DateTime datePost { get; set; }
		
		public string postText { get; set; }

        [ForeignKey(nameof(Utilizador))]
        public int ownerId { get; set; }
        public  Utilizador utilizadores { get; set; }

    }
}
