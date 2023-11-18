namespace ElectronicQuere
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SecondName { get; set; }
		public string FatheredName { get; set; }
		public int StudentNumber {  get; set; }
		public int GroupNumber {  get; set; }
		public string Login {  get; set; }
		public string Password { get; set; }

		public ICollection<LaboratoryWork> LaboratoryWorks {  get; set; }
	}
}
