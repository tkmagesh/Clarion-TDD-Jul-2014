using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagerApp.Models;

namespace TaskManagerApp.Infrastructure
{
    public interface ITodoRepository
    {
        IList<Todo> GetAll();

        void Save(Todo todo);
    }
}