using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FCM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PushMessageController : ControllerBase
    {
        private readonly IFcm _fcm;
        public PushMessageController(IFcm fcm) {
            _fcm = fcm;
        }

        [HttpGet]
        public async Task<string> SendMessage()
        {
            var result = await _fcm.SendMessageAsync("/topics/news", "My Message Title", "Message Data", "");
            return result.Message;
        }


       

    }
}