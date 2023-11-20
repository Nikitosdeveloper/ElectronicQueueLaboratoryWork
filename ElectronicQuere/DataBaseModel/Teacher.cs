namespace ElectronicQuere.DataBaseModel
{
    public class Teacher : User
    {
		public int Id { get; set; }
		public string AcademicDegree { get; set; }

        public ICollection<LaboratoryWork> LaboratoryWorks { get; set; }
        public Group Group { get; set; }
    }
}
