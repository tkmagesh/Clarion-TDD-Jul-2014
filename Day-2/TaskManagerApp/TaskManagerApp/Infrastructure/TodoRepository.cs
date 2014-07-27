using System.Collections.Generic;
using TaskManagerApp.Models;

namespace TaskManagerApp.Infrastructure
{
    public class TodoRepository : ITodoRepository
    {
        public IList<Todo> GetAll()
        {
            return null;
        }

        public void Save(Todo todo)
        {
            
        }
    }
}