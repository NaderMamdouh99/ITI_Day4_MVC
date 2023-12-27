using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class SchoolController : Controller
    {
        School school = new School();
        // GET: School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAll()
        {
            return PartialView(school.Departments.ToList());
        }
        [HttpGet]
        public ActionResult Create() 
        {
            ViewData["Instructor"] = school.Instructors.ToList();
            return PartialView(new Department());
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                school.Departments.Add(department);
                school.SaveChanges();
                RedirectToAction("Index");
            }
            ViewData["Instructor"] = school.Instructors.ToList();
            return PartialView(department);
        }

        public ActionResult Delete(int id)
        {
            var found = school.Departments.Where(d => d.Dept_Id == id).FirstOrDefault();
            var Ins = school.Instructors.Where(i => i.Dept_Id == id).ToList();
            school.Departments.Remove(found);
            school.Instructors.RemoveRange(Ins);
            school.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}