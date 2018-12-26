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
           
            return View();
        }


        public IActionResult StudyWords()
        {
            SpeechTtsService.SpeechSynthesis("111111111", "小叮当。 这个单词读：One。。。。One。。。。One。。。。  中文解释:一个、第一。。。  你学会了吗?");




            return View();
        }





    }
}