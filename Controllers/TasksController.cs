using Microsoft.AspNetCore.Mvc;
using TaskApi.Contracts;
using TaskApi.Models;
using TaskApi.Services;

namespace TaskApi.Controllers;

[Route("api/manager")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly ITaskService _service;

    public TasksController(ITaskService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var data = await _service.FetchAllAsync();
        var result = data.Select(x => new TaskItemDto(x.Id, x.Title, x.IsDone));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(NewTaskDto input)
    {
        var entity = new TaskEntity(input.Title, input.IsDone);
        await _service.AddTaskAsync(entity);

        var response = new TaskItemDto(entity.Id, entity.Title, entity.IsDone);
        
        return CreatedAtAction(nameof(GetSingle), new { id = entity.Id }, response);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetSingle(int id)
    {
        var item = await _service.FindByIdAsync(id);
        if (item is null)
            return NotFound("Item not found");

        return Ok(new TaskItemDto(item.Id, item.Title, item.IsDone));
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, UpdateTaskDto input)
    {
        var entity = new TaskEntity(input.Title, input.IsDone) { Id = id };
        var updated = await _service.EditAsync(id, entity);

        if (updated is null)
            return NotFound("Target item does not exist");

        return Ok(new TaskItemDto(updated.Id, updated.Title, updated.IsDone));
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _service.RemoveAsync(id);

        if (!success)
            return NotFound("Cannot delete non-existent item");

        return NoContent();
    }
}
