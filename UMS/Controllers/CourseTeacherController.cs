using Microsoft.AspNetCore.Mvc;
using UMS.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace UMS.Controllers
{
    public class CourseTeacherController : Controller
    {
        public IActionResult Index()
        {
            IList<CourseTeacherView> courseTeachersList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("CourseTeacher").Result;
            courseTeachersList = response.Content.ReadAsAsync<IList<CourseTeacherView>>().Result;

            return View(courseTeachersList);
        }

        public ActionResult AddOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new CourseTeacherView());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("CourseTeacher/" + id.ToString()).Result;

                return View(response.Content.ReadAsAsync<CourseTeacherView>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(CourseTeacherView courseTeacher)
        {
            if (courseTeacher.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("CourseTeacher", courseTeacher).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("CourseTeacher", courseTeacher).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("CourseTeacher/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete Successfuly";

            return RedirectToAction("Index");
        }
    }
}
