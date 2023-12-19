using CourseManagement.ViewModels;

namespace CourseManagement.Services
{
    public interface ILessonsService
    {
        Task<IEnumerable<LessonViewModel>> GetAllFilter(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);
        Task<LessonViewModel> GetById(int id);
        Task<int> Create(LessonRequest request);
        Task<int> Update(LessonViewModel request);
        Task<int> Delete(int id);
    }
}