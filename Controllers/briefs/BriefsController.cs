using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dreams
{
    public class BriefsController : Controller
    {
        public IActionResult Index()
        {
            List<Dictionary<string, object>> data = new()
        {
            new()
            {
                {"Id", 1},
                {"Company Name", "Dreams"},
                {"Description", "Pioneering tech solutions in healthcare, accessibility, robotics, transportation, security, environment, and space exploration for a better future."},
                {"Group members & roles", "Sukhpreet Saini- Full Stack Developer"}
            },
            new()
            {
                {"Id", 2},
                {"Company Name", "Dreams"},
                {"Description", "Pioneering tech solutions in healthcare, accessibility, robotics, transportation, security, environment, and space exploration for a better future."},
                {"Group members & roles", "Abin Byju- Front-End Developer"}
            }
        };
            return View(data);
        }
    }

}