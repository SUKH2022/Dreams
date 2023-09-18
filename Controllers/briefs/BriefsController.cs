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
                    {"Description", "Pioneering healthcare AI solutions for a better future."},
                    {"Group members & roles", "Sukhpreet Saini- Full Stack Developer"}
                },
                new()
                {
                    {"Id", 2},
                    {"Company Name", "Dreams"},
                    {"Description", "Pioneering healthcare AI solutions for a better future."},
                    {"Group members & roles", "Abin Byju- Front-End Developer"}
                }
            };

            ViewData["ProposalData"] = new
            {
                description = "Dreams Innovations is an innovative platform dedicated to transforming lives through cutting-edge healthcare AI technology. We aim to provide a one-stop solution for individuals seeking groundbreaking advancements in healthcare. At Dreams Innovations, we believe in pushing the boundaries of what's possible to create a better future for all.",
                ProductsOrServices = "Dreams Innovations provides AI-powered healthcare solutions.",
                IndustryNeed = "Dreams Innovations fulfills a crucial need in the healthcare industry by harnessing AI technology to improve early disease detection, treatment recommendations, and healthcare insights. Our solutions address pressing challenges and drive innovation in the healthcare sector, ultimately benefiting individuals and communities.",
                UserRoles = "User roles at Dreams Innovations include admins responsible for platform management, customers with access to healthcare AI solutions, and members who engage in community forums and receive updates on healthcare initiatives."
            };

            return View(data);
        }
    }
}
