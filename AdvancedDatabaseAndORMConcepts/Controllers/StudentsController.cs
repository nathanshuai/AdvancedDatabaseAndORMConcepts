using AdvancedDatabaseAndORMConcepts_Lab3.Models;
using AdvancedDatabaseAndORMConcepts_Lab3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdvancedDatabaseAndORMConcepts_Lab3.Models.ViewModels;
using FirstDbMVCApp.Models.ViewModels;

namespace AdvancedDatabaseAndORMConcepts_Lab3.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AdvancedDatabaseAndORMConcepts_Lab3Context _context;

        public StudentsController(AdvancedDatabaseAndORMConcepts_Lab3Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            else
            {
                return View(_context.Students.Include(s => s.Course).ToHashSet());
            }
        }

        public IActionResult Create()
        {
            // in create method, add a dropdown list of all course names
            HashSet<Course> courses = _context.Course.ToHashSet();

            CreateStudentVM vm = new CreateStudentVM(courses);
            vm.NewStudent = new Student();

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(CreateStudentVM vm)
        {

            Student student = vm.NewStudent;
            student.CourseId = vm.SelectedCourseId;

            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(student);
            }

        }

        // UPDATE

        public IActionResult Edit(Guid? id)
        {
            if (id == null || _context.Students == null || _context.Course == null)
            {
                return NotFound();
            }

            Student student = _context.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }


            CUStudentVM vm = new CUStudentVM(_context.Course.ToHashSet());
            vm.SelectedCourseId = student.CourseId;
            vm.Student = student;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(CUStudentVM vm)
        {
            Student student = vm.Student;
            student.CourseId = vm.SelectedCourseId;

            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Problem("Error handling Student entity changes.");
            }
        }

    }
}

