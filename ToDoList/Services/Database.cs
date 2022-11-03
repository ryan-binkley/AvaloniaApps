using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class Database
    {
        public IEnumerable<TodoItem> GetItems() => new[]
        {
            new TodoItem {Description = "Walk the dog."},
            new TodoItem {Description = "Buy some milk."},
            new TodoItem {Description = "Learn Avalonia", IsChecked = true},
        };
    }
}

