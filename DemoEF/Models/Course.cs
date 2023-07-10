using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEF.Models
{
    public class Course
    {
        
        public string Course_ID { get; set; }
        public string Course_Name { get; set; }
        public float Course_Ects { get; set; }
        
        public int Professor_ID { get; set; }
        public Professor Professor { get; set; }
    }
}
