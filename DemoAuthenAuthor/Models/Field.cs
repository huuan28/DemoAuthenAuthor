using System.ComponentModel.DataAnnotations;

namespace DemoAuthenAuthor.Models
{
	public class Field
	{
        [Key]
        public string Id { get; set; }
        public double Price { get; set; }
    }
}
