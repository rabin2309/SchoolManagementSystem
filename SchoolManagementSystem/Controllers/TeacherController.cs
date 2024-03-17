using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Models.TeacherModel;
using SchoolManagementSystem.Models.ViewModels;
using SchoolManagementSystem.Models.ViewModels.TeacherViewModels;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {

        private readonly ITeacherRepository _teacherRepository;




        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeacherList()
        {

            TeacherListViewModel studentListViewModel = new TeacherListViewModel(_teacherRepository.AllTeacher);
            return View(studentListViewModel);
        }

        public ActionResult AddTeacher()
        {
            var viewModel = new AddTeacherViewModel();
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddTeacher(AddTeacherViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                Teacher newTeacher = new Teacher
                {
                    Name = viewModel.Name,
                    Picture = viewModel.Picture,
                    PhoneNumber = viewModel.PhoneNumber,
                    Subject = viewModel.Subject,
                };
                _teacherRepository.AddTeacher(newTeacher);
            }
            return View();
        }

        [HttpGet]
        public ActionResult UpdateTeacher(int id)
        {
            var student = _teacherRepository.GetTeacherById(id);

            var editTeacherViewModel = new UpdateTeacherViewModel
            {
                TeacherId = student.TeacherId,
                Name = student.Name,
                Picture = student.Picture,
                PhoneNumber = student.PhoneNumber,
                Subject = student.Subject,
            };


            return View(editTeacherViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateTeacher(UpdateTeacherViewModel model)
        {
            var teacher = _teacherRepository.GetTeacherById(model.TeacherId);

            teacher.Name = model.Name;
            teacher.Picture = model.Picture;
            teacher.PhoneNumber = model.PhoneNumber;
            teacher.Subject = model.Subject;

            _teacherRepository.UpdateTeacher(teacher);
            return RedirectToAction("TeacherList");
        }




        public IActionResult DeleteTeacher(int id)
        {

            _teacherRepository.DeleteTeacher(id);

            return RedirectToAction("TeacherList");


        }

    }
}