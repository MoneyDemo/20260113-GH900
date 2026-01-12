namespace TodoWebApp.Services;

using TodoWebApp.Models;

public interface ITodoService
{
    List<TodoItem> GetAll();
    TodoItem? GetById(int id);
    void Add(TodoItem item);
    void Update(TodoItem item);
    void Delete(int id);
    void ToggleComplete(int id);
}

public class InMemoryTodoService : ITodoService
{
    private readonly List<TodoItem> _todos = new();
    private int _nextId = 1;

    public InMemoryTodoService()
    {
        // Add some sample data for demo
        Add(new TodoItem { Title = "建立 .NET 10 MVC 專案" });
        Add(new TodoItem { Title = "實作 TODO 功能" });
        Add(new TodoItem { Title = "測試應用程式" });
    }

    public List<TodoItem> GetAll() => _todos.OrderByDescending(t => t.CreatedDate).ToList();

    public TodoItem? GetById(int id) => _todos.FirstOrDefault(t => t.Id == id);

    public void Add(TodoItem item)
    {
        item.Id = _nextId++;
        item.CreatedDate = DateTime.Now;
        _todos.Add(item);
    }

    public void Update(TodoItem item)
    {
        var existing = GetById(item.Id);
        if (existing != null)
        {
            existing.Title = item.Title;
            existing.IsCompleted = item.IsCompleted;
        }
    }

    public void Delete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            _todos.Remove(item);
        }
    }

    public void ToggleComplete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            item.IsCompleted = !item.IsCompleted;
        }
    }
}
