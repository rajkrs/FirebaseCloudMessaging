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
    public class RegistrationController : ControllerBase
    {
        private readonly IFcm _fcm;
        public RegistrationController(IFcm fcm) {
            _fcm = fcm;
        }

        [HttpGet("add")]
        public async Task<string> RegisterToken(string token, string topic)
        {
            var result = await _fcm.SubscribeTopicsAsync(new List<string> { token }, topic);
            return result.Message;
        }


        [HttpGet("remove")]
        public async Task<string> RemoveToken(string token, string topic)
        {
            var result = await _fcm.UnSubscribeTopicsAsync(new List<string> { token }, topic);
            return result.Message;
        }

    }
}