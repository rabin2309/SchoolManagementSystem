using SchoolManagementSystem.Models;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models.StudentModel
{
    public interface IStudentRepository
    {
        IEnumerable<Student> AllStudent { get; }
        void AddStudent(Student student);
        Student? GetStudentById(int studentId);
        void UpdateStudent(Student student);
        void DeleteStudent(int student);


    }
}