using System.ComponentModel.DataAnnotations;   // For Model Data Validation.

namespace MVC_in_Dotnet.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter the Name..!")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter the RollNo..!")]
        [Range(0,61)]
        public int? RollNo { get; set; }

        [Required(ErrorMessage = "Please Enter the CGPA..!")]
        public float? CGPA { get; set; }
        [Required(ErrorMessage = "Please Enter the Semester..!")]
        public string Semester { get; set; }

    }

}
