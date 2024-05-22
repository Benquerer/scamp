using System.ComponentModel.DataAnnotations;

namespace scamp.Models
{
    /// <summary>
    /// This class represents a comment which is a type of interaction that can be made on a post.
    /// The commentaries have a length limitation and need to have a content.
    /// </summary>
	public class Comment : Interaction {

        /// <summary>
        /// The comment's text content. 
        /// Can't be empty. The comments are limited to 500 characters.
        /// </summary>
        [Required]
        public string Commtxt { get; set; }
	}
}
