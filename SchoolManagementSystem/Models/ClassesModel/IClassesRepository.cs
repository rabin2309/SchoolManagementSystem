using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Models.ClassesModel
{
    public interface IClassesRepository
    {

        IEnumerable<Classes> AllClasses { get; }
        void AddClasses(Classes classes);
        Classes? GetClassesById(int classesId);
        void UpdateClasses(Classes classes);
        void DeleteClasses(int classes);
    }
}