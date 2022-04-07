using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Net.Http;

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

        public ActionResult AddOrEdit(int id)
        {
            if(id == 0)
            {
                return View(new StudentView());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Student/" + id.ToString()).Result;

                return View(response.Content.ReadAsAsync<StudentView>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(StudentView student)
        {
            if(student.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Student", student).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Student", student).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Student/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete Successfuly";

            return RedirectToAction("Index");
        }
    }
}
