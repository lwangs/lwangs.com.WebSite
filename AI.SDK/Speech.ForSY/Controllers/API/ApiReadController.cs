using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Speech.ForSY.Service;

namespace Speech.ForSY.Controllers.API
{
    [Produces("application/json")]
    [Route("api/ApiRead")]
    public class ApiReadController : Controller
    {

        public JsonResult readContent(string readEnglisID)
        {



           



            return Json(null);
        }

    }
}