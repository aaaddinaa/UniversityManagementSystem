using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace MVC.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index()
        {
            IList<EnrollmentView> enrollmentsList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Enrollment").Result;
            enrollmentsList = response.Content.ReadAsAsync<IList<EnrollmentView>>().Result;

            return View(enrollmentsList);
        }

        public ActionResult AddOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new EnrollmentView());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Enrollment/" + id.ToString()).Result;

                return View(response.Content.ReadAsAsync<EnrollmentView>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(EnrollmentView enrollment)
        {
            if (enrollment.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Enrollment", enrollment).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Enrollment", enrollment).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Enrollment/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete Successfuly";

            return RedirectToAction("Index");
        }
    }
}
