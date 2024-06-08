using System.ComponentModel.DataAnnotations;

namespace DemoAuthenAuthor.Models
{
	public class Booking
	{
		[Key]
		public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string FieldId { get; set; }
        public Field Field { get; set; }
    }
}
