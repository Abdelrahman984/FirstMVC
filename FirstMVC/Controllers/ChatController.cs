﻿using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
