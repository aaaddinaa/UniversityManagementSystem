using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace MVC.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            IList<TeacherView> teacherList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Teacher").Result;
            teacherList = response.Content.ReadAsAsync<IList<TeacherView>>().Result;

            return View(teacherList);
        }

        public ActionResult AddOrEdit(int id)
        {
            if(id == 0)
            {
                return View(new TeacherView());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Teacher/" + id.ToString()).Result;

                return View(response.Content.ReadAsAsync<TeacherView>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(TeacherView teacher)
        {
            if(teacher.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Teacher", teacher).Result;
                TempData["SuccesMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Teacher", teacher).Result;
                TempData["SuccesMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("teacher/" + id.ToString()).Result;
            TempData["SuccesMessage"] = "Delete Successfully";

            return RedirectToAction("Index");
        }
    }
}
