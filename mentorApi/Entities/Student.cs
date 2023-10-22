namespace mentorApi.Entities
{
    public class Student:BaseEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public School School { get; set; }
        public int SchoolId { get; set; }//foreign key
        public string Name { get;  set; }
    }
}
