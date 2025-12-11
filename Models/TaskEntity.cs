namespace TaskApi.Models;
public class TaskEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsDone { get; set; }
    public TaskEntity() { }
    public TaskEntity(string title, bool isDone) { Title = title; IsDone = isDone; }
}
