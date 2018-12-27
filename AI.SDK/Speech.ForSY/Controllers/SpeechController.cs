using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Speech.ForSY.Model.filter;
using Speech.ForSY.Service;
using Speech.ForSY.Service.ThirdService;

namespace Speech.ForSY.Controllers
{
    public class SpeechController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }


        public IActionResult StudyWords(string catagoryID)
        {
            catagoryID = "50E36017-EE0B-41D3-B88E-1708693288BE";
            var getEnglishByCatagory = EnglishWordsService.GetEnglishWorlds(new EnglishWordSearch { CatagoryID = catagoryID });
            ViewBag.allEnglishWordsByCatagory = getEnglishByCatagory;
            return View();
        }





    }
}