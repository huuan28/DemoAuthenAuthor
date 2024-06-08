using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DemoAuthenAuthor.Models
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Field> Fields { get; set; }
		public DbSet<Booking> Bookings { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Đổi tên các bảng Identity
			//builder.Entity<AppUser>(entity => { entity.ToTable(name: "Users"); });
			//builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Roles"); });
			//builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });
			//builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
			//builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
			//builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
			//builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });

			builder.Entity<Booking>()
		   .HasOne(i => i.User)
		   .WithMany()
		   .HasForeignKey(i => i.UserId);

			builder.Entity<Booking>()
		   .HasOne(i => i.Field)
		   .WithMany()
		   .HasForeignKey(i => i.FieldId);
		}
	}
}
