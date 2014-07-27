using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using TaskManagerApp.Controllers;
using TaskManagerApp.Infrastructure;
using TaskManagerApp.Models;

namespace TaskManagerApp.Tests.Controllers
{
    [TestFixture]
    public class TasksControllerTests
    {
        [Test]
        public void Should_Show_List_View_By_Default()
        {
            //Arrange
            
            var todoRepositoryMock = new Moq.Mock<ITodoRepository>();
            var controller = new TasksController(todoRepositoryMock.Object);
            var sampleTodo = new List<Todo>();

            //Act
            var result = (ViewResult) controller.List();

            //Assert
            Assert.That(result.ViewData, Is.EqualTo(sampleTodo));
        }

        [Test]
        public void Should_Save_The_New_Todo()
        {
            //Arrange

            var todoRepositoryMock = new Moq.Mock<ITodoRepository>();
            var controller = new TasksController(todoRepositoryMock.Object);
            var newTodo = new Todo();

            //Act
            var result = (ActionResult)controller.Save(newTodo);

            //Assert
            todoRepositoryMock.Verify(ts => ts.Save(newTodo));
        }


    }
}
