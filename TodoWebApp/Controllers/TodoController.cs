using Microsoft.AspNetCore.Mvc;
using TodoWebApp.Models;
using TodoWebApp.Services;

namespace TodoWebApp.Controllers;

public class TodoController : Controller
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public IActionResult Index()
    {
        var todos = _todoService.GetAll();
        return View(todos);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(TodoItem item)
    {
        if (ModelState.IsValid && !string.IsNullOrWhiteSpace(item.Title))
        {
            _todoService.Add(item);
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    public IActionResult Edit(int id)
    {
        var item = _todoService.GetById(id);
        if (item == null)
        {
            return NotFound();
        }
        return View(item);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(TodoItem item)
    {
        if (ModelState.IsValid && !string.IsNullOrWhiteSpace(item.Title))
        {
            _todoService.Update(item);
            return RedirectToAction(nameof(Index));
        }
        return View(item);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        _todoService.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult ToggleComplete(int id)
    {
        _todoService.ToggleComplete(id);
        return RedirectToAction(nameof(Index));
    }
}
