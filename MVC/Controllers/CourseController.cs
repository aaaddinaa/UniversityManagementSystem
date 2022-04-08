using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Net.Http;


namespace MVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            IList<CourseView> coursesList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Course").Result;
            coursesList = response.Content.ReadAsAsync<IList<CourseView>>().Result;

            return View(coursesList);
        }

        public ActionResult AddOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new CourseView());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Course/" + id.ToString()).Result;

                return View(response.Content.ReadAsAsync<CourseView>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(CourseView course)
        {
            if (course.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Course", course).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Course", course).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Course/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete Successfuly";

            return RedirectToAction("Index");
        }
    }
}
