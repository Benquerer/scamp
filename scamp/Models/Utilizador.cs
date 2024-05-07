using System.ComponentModel.DataAnnotations;

namespace scamp.Models
{
	public class Utilizador {

		[Key] public int id { get; set; }

		public string username { get; set; }

		public string passwd { get; set; }

		public string email { get; set; }

		public string profPic { get; set; }
	}
}
