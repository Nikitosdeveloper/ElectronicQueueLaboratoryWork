using ElectronicQuere.DataBaseModel;
using Microsoft.EntityFrameworkCore;
namespace ElectronicQueue
{
    public class Repository:DbContext
	{
		public DbSet<Student> Students { get; set; } = null!;
		public DbSet<LaboratoryWork> LaboratoryWorks { get; set; } = null!;
		public DbSet<Teacher> Teachers { get; set; } = null!;
		public DbSet<Group> Groups { get; set; } = null!;
		public Repository() : base()
		{
			Students = Set<Student>();
			LaboratoryWorks = Set<LaboratoryWork>();
			Teachers = Set<Teacher>();
			Groups = Set<Group>();
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
			//Связь один ко многим между преподами и лабораторными работами
			modelBuilder.Entity<Teacher>()
				.HasMany(s => s.LaboratoryWorks)
				.WithOne(l => l.Teacher)
				.HasForeignKey(l => l.TeacherId)
				.OnDelete(DeleteBehavior.Restrict);
			//Связь один ко одному между преподами и группами
			modelBuilder.Entity<Teacher>()
				.HasOne(s => s.Group)
				.WithOne(l => l.Teacher)
				.HasForeignKey<Group>(l => l.TeacherId);
			//Связь один ко многим между группой и студентами
			modelBuilder.Entity<Group>()
				.HasMany(s => s.Students)
				.WithOne(l => l.Group)
				.HasForeignKey(l => l.GroupId);

			base.OnModelCreating(modelBuilder);
		}
	}
}
