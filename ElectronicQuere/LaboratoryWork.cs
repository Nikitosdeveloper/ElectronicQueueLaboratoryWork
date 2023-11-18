namespace ElectronicQuere
{
	public class LaboratoryWork
	{
		public int Id {  get; set; }
		public string LaboratoryWorkName { get; set; }
		public bool IsCompleted {  get; set; }

		public int StudentId {  get; set; }
		public Student Student { get; set; }
	}
}
