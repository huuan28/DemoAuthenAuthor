
using Microsoft.AspNetCore.Identity;

namespace DemoAuthenAuthor.Models
{
	public class AppUser : IdentityUser
	{
        public string FullName { get; set; }
    }
}
