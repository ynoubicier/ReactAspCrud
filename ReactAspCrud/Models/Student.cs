using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string stname { get; set; }
        public string course { get; set; }
    }
}
