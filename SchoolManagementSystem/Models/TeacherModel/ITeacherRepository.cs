namespace SchoolManagementSystem.Models.TeacherModel
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> AllTeacher { get; }
        void AddTeacher(Teacher teacher);
        Teacher? GetTeacherById(int teacherId);
        void UpdateTeacher(Teacher tecaher);
        void DeleteTeacher(int teacher);
    }
}
