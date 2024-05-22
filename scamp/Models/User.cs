using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	public class User {

		[Key] public int Id { get; set; }

		[Required]
		public string Username { get; set; }

        [Required]
        public string Passwd { get; set; }

        [Required]
        public string Email { get; set; }

		public string Profpic { get; set; }

		[ForeignKey(nameof(Course))]
		public int CourseFK { get; set; }
		public Course Course { get; set; }

	}
}
