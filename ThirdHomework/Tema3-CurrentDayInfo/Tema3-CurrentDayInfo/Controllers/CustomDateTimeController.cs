using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tema3_CurrentDayInfo.Models;

namespace Tema3_CurrentDayInfo.Controllers
{
    [Route("/[controller]")]
    public class CustomDateTimeController : Controller
    {
        private readonly CustomDateTimeRepository _repo;
        public CustomDateTimeController(CustomDateTimeRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var currentDateTime = _repo.CurrentDateTime;

            return View(currentDateTime);
        }
    }
}