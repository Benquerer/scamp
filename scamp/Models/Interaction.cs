using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scamp.Models
{
    /// <summary>
    /// This class represents the interactions that can be made on a post.
    /// Interactions can either be likes or comments. Multiple interactions can be made on a post. 
    /// All interctions must have an owner and a post they are related to.
    /// </summary>
	public class Interaction {
        
        // A interaction can either be a like or a comment.

        /// <summary>
        /// The Interaction's unique identifier
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The user who made the interaction
        /// </summary>
        [ForeignKey(nameof(User))]
        public int OwnerFK { get; set; }
        public User User { get; set; }

        /// <summary>
        /// The post that the interaction is related to
        /// </summary>
        [ForeignKey(nameof(Post))]
        public int PostFK { get; set; }
        public Post Post { get; set; }
    }
}
