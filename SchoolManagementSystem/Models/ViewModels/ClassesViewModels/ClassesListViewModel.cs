namespace SchoolManagementSystem.Models.ViewModels.ClassesViewModels
{
    public class ClassesListViewModel
    {

        public IEnumerable<Classes> Classes { get; }

        public ClassesListViewModel(IEnumerable<Classes> classes)
        {

            Classes = classes;
        }

    }
}
