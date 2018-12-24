using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Speech.ForSY.Service;

namespace Speech.ForSY.Controllers
{
    public class SpeechController : Controller
    {
        public IActionResult Index()
        {
            //SpeechTtsService.SpeechSynthesis();
            return View();
        }


        public IActionResult StudyWords()
        { 
            return View();
        }





    }
}