namespace ElectronicQuere.DataBaseModel
{
    public class Student : User
    {
		public int Id { get; set; }
		public int StudentNumber { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<LaboratoryWork> LaboratoryWorks { get; set; }
    }
}
