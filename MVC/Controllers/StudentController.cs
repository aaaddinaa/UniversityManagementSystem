using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            IList<StudentView> studentsList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Student").Result;
            studentsList = response.Content.ReadAsAsync<IList<StudentView>>().Result;

            return View(studentsList);
        }
    }
}
