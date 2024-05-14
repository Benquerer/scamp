using System.ComponentModel.DataAnnotations;

namespace scamp.Models
{
	public class Curso {

        [Key] public int id { get; set; }

        public string name { get; set; }

        public string abrev { get; set; }

        public string color { get; set; }

        public string logo { get; set; }


    }
}
