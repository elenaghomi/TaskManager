using Microsoft.EntityFrameworkCore;
using TaskApi.Data;
using TaskApi.Models;

namespace TaskApi.Services;

public class TaskService : ITaskService
{
    private readonly AppDbContext _db;

    public TaskService(AppDbContext db)
    {
        _db = db;
    }

    public async Task AddTaskAsync(TaskEntity task)
    {
        _db.Tasks.Add(task);
        await _db.SaveChangesAsync();
    }

    public async Task<bool> RemoveAsync(int id)
    {
        var target = await _db.Tasks.FindAsync(id);
        if (target is null) return false;

        _db.Tasks.Remove(target);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<List<TaskEntity>> FetchAllAsync()
    {
        return await _db.Tasks.ToListAsync();
    }

    public async Task<TaskEntity?> FindByIdAsync(int id)
    {
        return await _db.Tasks.FindAsync(id);
    }

    public async Task<TaskEntity?> EditAsync(int id, TaskEntity task)
    {
        var existing = await _db.Tasks.FindAsync(id);
        if (existing is null) return null;

        existing.Title = task.Title;
        existing.IsDone = task.IsDone;

        await _db.SaveChangesAsync();
        return existing;
    }
}
