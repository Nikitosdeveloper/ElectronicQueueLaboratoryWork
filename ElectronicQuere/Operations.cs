using Microsoft.EntityFrameworkCore;

namespace ElectronicQuere
{
	public class Operations
	{
		public static int Create(Student student)
		{
			int newId = 0;
			using (Repository db = new Repository())
			{
				db.Students.Add(student);
				db.SaveChanges();
				newId = student.Id;
			}
			return newId;
		}

		public static IEnumerable<Student> Read()
		{
			List<Student> list = new List<Student>();
			using (Repository db = new Repository())
			{
				list = db.Students
					.Include(s => s.LaboratoryWorks) // Предварительная загрузка лабораторных работ
					.ToList();
			}
			return list;
		}



		public static Student? Read(int Id)
		{
			Student? student = null;
			using (Repository db = new Repository())
			{
				student = db.Students
				.Include(s => s.LaboratoryWorks) // Предварительная загрузка лабораторных работ
				.FirstOrDefault(s => s.Id == Id);
			}
			return student;
		}

		public static Student? Read(string Login)
		{
			Student? student = null;
			using (Repository db = new Repository())
			{
				student = db.Students
					.Include(s => s.LaboratoryWorks)
					.FirstOrDefault(s=> s.Login == Login);
			}
			return student;
		}

		public static void Update(Student student)
		{
			using (Repository db = new Repository())
			{
				db.Students.Update(student);
				db.SaveChanges();
			}
		}

		public static void delete(Student student)
		{
			using (Repository db = new Repository())
			{
				db.Students.Remove(student);
				db.SaveChanges();
			}
		}


	}
}
