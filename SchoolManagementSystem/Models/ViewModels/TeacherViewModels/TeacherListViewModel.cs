namespace SchoolManagementSystem.Models.ViewModels.TeacherViewModels
{
    public class TeacherListViewModel
    {
        public IEnumerable<Teacher> Teachers { get; }

        public TeacherListViewModel(IEnumerable<Teacher> teachers)
        {
            Teachers = teachers;
        }
    }
}
