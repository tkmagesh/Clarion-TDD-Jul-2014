using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagerApp.Infrastructure;
using TaskManagerApp.Models;

namespace TaskManagerApp.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITodoRepository _repository;
        //
        // GET: /Tasks/

        public TasksController(ITodoRepository repository)
        {
            _repository = repository;
        }

        public TasksController()
        {
            _repository = new TodoRepository();
        }

        public ActionResult List()
        {
            return View(_repository.GetAll());
        }

        public ActionResult Save(Todo todo)
        {
            //_repository.Save(todo);
            return RedirectToAction("List");
        }

    }
}
