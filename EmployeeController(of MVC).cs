using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employee").Result;// Getting The Get Method From WebApi
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;//Here we are creating Result type to IEnumerable
            return View(empList);
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)// if id=0, we will return an empty form
                return View(new mvcEmployeeModel());// Here we passses the object of mvcEmployeeModel
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employee/" + id.ToString()).Result;// else we will call Get Method of ID parameter
                return View(response.Content.ReadAsAsync<mvcEmployeeModel>().Result);// Here we are converting the response to MvcEmployeeModel
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcEmployeeModel emp)
        {
            if (emp.EmployeeID == 0)// if id=0, we will do create operation 
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employee", emp).Result;// Getting The Post Method From WebApi
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else   // else we will do update  Operation
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employee/" + emp.EmployeeID, emp).Result;// Getting the Post Operation
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employee/" + id.ToString()).Result;// Getting The Delete Method From WebApi
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}