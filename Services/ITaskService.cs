using TaskApi.Models;
namespace TaskApi.Services;
public interface ITaskService
{
    Task<List<TaskEntity>> FetchAllAsync();
    Task AddTaskAsync(TaskEntity task);
    Task<TaskEntity?> FindByIdAsync(int id);
    Task<TaskEntity?> EditAsync(int id, TaskEntity task);
    Task<bool> RemoveAsync(int id);
}
