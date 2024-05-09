using EFCoreTutorialsConsoleGonchi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialsConsoleGonchi.Repositories
{
	public class SchoolDbContext: DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Grade> Grades { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=EFCoreSchoolTutorialGonchi;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
		}
	}
}
