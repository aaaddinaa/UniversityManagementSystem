using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace MVC.Controllers
{
    public class OfficeController : Controller
    {
        public IActionResult Index()
        {
            IList<OfficeView> officesList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Office").Result;
            officesList = response.Content.ReadAsAsync<IList<OfficeView>>().Result;

            return View(officesList);
        }

        public ActionResult AddOrEdit(int id)
        {
           if(id == 0)
            {
                return View(new OfficeView());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Office/" + id.ToString()).Result;

                return View(response.Content.ReadAsAsync<OfficeView>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(OfficeView office)
        {
            if(office.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Office", office).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Office", office).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Office/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete Successfully";

            return RedirectToAction("Index");
        }
    }
}
