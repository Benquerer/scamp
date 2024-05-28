using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
	/// <summary>
	/// This class represents a user of the social network.
	/// The uses can make posts, comments and likes. As well as being associated with a course.
	/// </summary>
	public class User {
		/// <summary>
		/// The user's unique identifier
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		///	The user's username for login and display. 
		///	Must be unique for each user
		/// </summary>
		[Required]
		public string Username { get; set; }

		/// <summary>
		/// The user's password for login
		/// </summary>
        [Required]
        public string Passwd { get; set; }


		/// <summary>
		/// The user's email for contact, login. 
		/// Must be unique for each user
		/// </summary>
        [Required]
        public string Email { get; set; }

		/// <summary>
		/// The user's Profile Picture
		/// </summary>
		public string Profpic { get; set; }

		/// <summary>
		/// The user's associated course. A user can only be associated with one course
		/// A user doesn't need to be associated with a course.
		/// </summary>
		[ForeignKey(nameof(Course))]
		public int CourseFK { get; set; }
		public Course Course { get; set; }

	}
}
