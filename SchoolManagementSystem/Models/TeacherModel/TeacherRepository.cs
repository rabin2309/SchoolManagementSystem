using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models.TeacherModel;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Models.TeacherModel
{
    public class TeacherRepository : ITeacherRepository
    {


        private readonly SchoolManagementSystemDbContext _schoolManagementDbContext;

        public TeacherRepository(SchoolManagementSystemDbContext schoolManagementDbContext)
        {

            _schoolManagementDbContext = schoolManagementDbContext;
        }

        public IEnumerable<Teacher> AllTeacher
        {
            get
            {
                return _schoolManagementDbContext.Teachers;
            }
        }
        public void AddTeacher(Teacher teacher)
        {

            _schoolManagementDbContext.Teachers.Add(teacher);
            _schoolManagementDbContext.SaveChanges();
        }


        public Teacher? GetTeacherById(int teacherId)
        {

            return _schoolManagementDbContext.Teachers.FirstOrDefault(p => p.TeacherId == teacherId);
        }

        public void UpdateTeacher(Teacher teacher)
        {

            var existingTecaher = _schoolManagementDbContext.Teachers.FirstOrDefault(p => p.TeacherId == teacher.TeacherId);
            if (existingTecaher == null)
            {
                throw new ArgumentException("student not found");
            }


            existingTecaher.Name = teacher.Name;
            existingTecaher.Picture = teacher.Picture;
            existingTecaher.PhoneNumber = teacher.PhoneNumber;
            existingTecaher.Subject = teacher.Subject;

            _schoolManagementDbContext.Entry(existingTecaher).State = EntityState.Modified;
            _schoolManagementDbContext.SaveChanges();
        }





        public void DeleteTeacher(int id)
        {

            var teacher = _schoolManagementDbContext.Teachers.Find(id);

            if (teacher == null)
            {
                throw new ArgumentException("teacher not found");
            }


            _schoolManagementDbContext.Teachers.Remove(teacher);
            _schoolManagementDbContext.SaveChanges();

        }

    }
}
