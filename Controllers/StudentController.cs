using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MVC_in_Dotnet.Models;
namespace MVC_in_Dotnet.Controllers
{
    public class StudentController : Controller
    {
        //public string Index()
        //{
        //    return "This is Index form Student Controller!";
        //}

        public ViewResult Index()
        {
            return View("Index");
        }
        public IActionResult StudentData()
        {
            return View("StudentData");
        }

        [HttpGet]
        public IActionResult StudentForm() 
        {
            return View("StudentForm");
        
        }
        //[HttpPost]
        //public IActionResult StudentForm(string name, string rollno, string cgpa, string semester)
        //{
        //    return View("StudentForm");

        //}

        // We can also recieve Object as a whole
        [HttpPost]
        public IActionResult StudentForm(Student s)
        {
            if(ModelState.IsValid)
            {
                StudentRepository.AddStudent(s);
                return View("DisplayStudentThanks", s);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please Enter Valid Data..!");
                return View();
            }
        }
            

        public IActionResult ListStudents(Student s)
        {
            return View("ListStudents",StudentRepository.students);
        }

        public IActionResult Details(int id)
        {
            Student s = StudentRepository.students.Find(s=>s.Id== id);

            return View("DisplayStudentThanks",s);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            Student s = StudentRepository.students.Find(s => s.Id == id);

             return View("Edit", s);
        }

        [HttpPost]
        public IActionResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
               foreach(Student std in StudentRepository.students)
                {
                    if(std.Id==s.Id)
                    {
                        std.Name=s.Name;
                        std.RollNo=s.RollNo;
                        std.CGPA=s.CGPA;
                        std.Semester = s.Semester;
                        break;
                    }
                }
               return View("ListStudents", StudentRepository.students);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please Enter Valid Data..!");
                return View();
            }

        }

        public IActionResult Remove(int id)
        {
            Student s = StudentRepository.students.Find(s => s.Id == id);
            StudentRepository.students.Remove(s);
            return View("ListStudents", StudentRepository.students);
        
        }
    }
}
