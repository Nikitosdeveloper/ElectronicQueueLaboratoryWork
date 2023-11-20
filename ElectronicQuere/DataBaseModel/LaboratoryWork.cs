namespace ElectronicQuere.DataBaseModel
{
    public class LaboratoryWork
    {
        public int Id { get; set; }
        public string LaboratoryWorkName { get; set; }
        public bool IsCompleted { get; set; }

        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
