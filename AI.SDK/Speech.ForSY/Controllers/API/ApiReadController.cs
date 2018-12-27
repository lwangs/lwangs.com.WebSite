using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Speech.ForSY.Service;
using Speech.ForSY.Service.ThirdService;

namespace Speech.ForSY.Controllers.API
{
    [Produces("application/json")]
    [Route("api/ApiRead")]
    public class ApiReadController : Controller
    {
        public ContentResult readContent(string englishID, string english, string chiness)
        {
            string voiceStr = "";
            for (int i = 0; i < 3; i++)
            {
                //voiceStr += "。。。";
                //english.ToArray().ToList().ForEach((x) =>
                //{
                //    voiceStr += string.Format("{0}。", x);
                //});
                //voiceStr += "。。。。";
                voiceStr += string.Format("{0}。。。。。。。。。。", english);
            }
            bool isSuccess = SpeechTtsService.SpeechSynthesis(englishID, string.Format("{0}  {1}", voiceStr, chiness));
            return Content(isSuccess ? englishID : "");
        }

    }
}