namespace ElectronicQuere.DataBaseModel
{
    public class Group
    {
        public int Id { get; set; }
        public string NameGroup { get; set; }
        public int NumberGroup { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
