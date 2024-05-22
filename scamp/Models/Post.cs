using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
    /// <summary>
    /// This class represents a post that can be made by a user.
    /// </summary>
	public class Post {

        /// <summary>
        /// The Post's unique identifier
        /// </summary>
		[Key]
        public int Id { get; set; }

        /// <summary>
        /// The post's date and time of creation
        /// </summary>
		public DateTime DatePost { get; set; }

        /// <summary>
        /// The post's text content
        /// </summary>
        [Required]
		public string PostText { get; set; }

        /// <summary>
        /// The post´s owner. 
        /// A post can only have one owner
        /// </summary>
        [ForeignKey(nameof(User))]
        public int UserFK { get; set; }
        public User User { get; set; }

    }
}
