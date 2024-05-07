using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class Post {

		[Key] public int id { get; set; }
		public DateTime datePost { get; set; }
		public string postText { get; set; }

        [ForeignKey(nameof(Utilizador))]
        public int ownerId { get; set; }
        public  Utilizador utilizador { get; set; }

    }
}
