using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace ReceiveCalls.Controllers
{
    public class VoiceController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            var response = new VoiceResponse();
            response.Say("Thank you for calling! Have a great day.");

            return TwiML(response);
        }
    }
}