using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //When data is posted to /Student/Register
        // this action will execute
        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            //Validate input (lot's of work!)
            // Server-side and client-side
            // Add error messages on page to notify user

            Student stu = new Student()
            {
                FullName = data["full-name"],
                ProgramOfChoice = data["program"],
                DateOfBirth = Convert.ToDateTime(data["dob"]),
                HomeAddress = data["address"]
            };

            // Add to database
            return View();
        }

        //Registration done with Model Binding!
        [HttpGet]
        public IActionResult RegisterMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterMB(Student s)
        {
            // This verifies that all data annotation in the class are valid
            if (ModelState.IsValid)
            {
                //Add to database
                StudentDB.Register(s);
                //Display tsuccess message
                ViewData["Success"] = "Student was successfully registered";
                return View();
            }

            return View();
        }
    }
}