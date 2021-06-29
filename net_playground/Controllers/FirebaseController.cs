using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace net_playground.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirebaseController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private string cToken;

        [HttpGet]
        public IActionResult TestFirebase() 
        {
            return Ok("Firebase ready to go");
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage() 
        {
            CreateCustomToken();

            client.DefaultRequestHeaders.Accept.Clear();
            dynamic obj = new ExpandoObject { };
            dynamic notif = new ExpandoObject { };

            notif.title = "helo world";
            notif.body = "there is a mountain and many trees";
            obj.data = new ExpandoObject { };
            obj.data.notification = notif;
            obj.to = "08785432353";

            var jsonInString = JsonConvert.SerializeObject(obj);
            //HttpContent content;
            client.PostAsync(requestUri, new StringContent())
            var result = await client.PostAsync("https://fcm.googleapis.com/fcm/send", new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            var msg = await stringTask;
        }

        [HttpGet("CreateCustomToken")]
        public async void CreateCustomToken()
        {
            var uid = "some-uid";
            var additionalClaims = new Dictionary<string, object>()
                {
                    { "premiumAccount", true },
                };

            string customToken = await FirebaseAuth.DefaultInstance
                .CreateCustomTokenAsync(uid, additionalClaims);
            // Send token back to client

            cToken = customToken;
        }
    }
}