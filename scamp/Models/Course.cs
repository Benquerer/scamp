using System.ComponentModel.DataAnnotations;

namespace scamp.Models
{
    /// <summary>
    /// This class represents a course in the University.
    /// Each course has a name, an abbreviation, a representative color and a logo.
    /// Courses can have multiple users associated with them.
    /// </summary>
	public class Course {

        /// <summary>
        /// The Course's unique identifier
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The course's name. 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// the course's abbreviation. 
        /// Must be unique for each course
        /// </summary>
        [Required]
        public string Abrev { get; set; }

        /// <summary>
        /// The course's representative color. 
        /// Must be a valid HEX color code.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The course's logo. Must be a valid URL.
        /// </summary>
        public string Logo { get; set; }


    }
}
