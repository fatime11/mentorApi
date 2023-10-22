namespace mentorApi.Entities
{
    public class School:BaseEntity
    {
        
        public   int Number { get; set; }
        public ICollection<Student> Students { get; set; }//navigation prop
        public string Name { get;  set; }
    }
}
