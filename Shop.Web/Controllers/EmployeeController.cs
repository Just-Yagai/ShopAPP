using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models;

namespace Shop.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeesDb employeesDb;
        public EmployeeController(IEmployeesDb employeesDb) 
        { 
            this.employeesDb = employeesDb;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = employeesDb.GetEmployees();

            return View(employees);
        }

        // GET: EmployeeController/Details/5s
        public ActionResult Details(int id)
        {
            var employees = employeesDb.GetEmployee(id);

            return View(employees);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeesAddModel employeesAdd)
        {
            try
            {
                employeesAdd.CreationDate = DateTime.Now;
                employeesAdd.CreationUser = 1;

                this.employeesDb.SaveEmployee(employeesAdd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employees = employeesDb.GetEmployee(id);

            return View(employees);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeesUpdateModel employeesUpdate)
        {
            try
            {
                employeesUpdate.ModifyDate = DateTime.Now;
                employeesUpdate.ModifyUser = 1;

                this.employeesDb.UpdateEmployee(employeesUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
