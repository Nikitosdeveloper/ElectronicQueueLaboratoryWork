using Microsoft.EntityFrameworkCore;
namespace ElectronicQuere
{
	public class Repository:DbContext
	{
		public DbSet<Student> Students { get; set; } = null!;
		public DbSet<LaboratoryWork> LaboratoryWorks { get; set; } = null!;
		public Repository() : base()
		{
			Students = Set<Student>();
			LaboratoryWorks = Set<LaboratoryWork>();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SeriousDataBase;Trusted_Connection=True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Связь один ко многим между студентами и лабораторными работами
			modelBuilder.Entity<Student>()
				.HasMany(s => s.LaboratoryWorks)
				.WithOne(l => l.Student)
				.HasForeignKey(l => l.StudentId);

			base.OnModelCreating(modelBuilder);
		}
	}
}
