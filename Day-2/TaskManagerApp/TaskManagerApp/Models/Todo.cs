using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagerApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; private set; }

        public Todo()
        {
            IsCompleted = false;
        }

        public void Complete()
        {
            this.IsCompleted = true;
        }
    }
}