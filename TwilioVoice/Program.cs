using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilioVoice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            const string authToken = "your_auth_token";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("9713449532");
            var from = new PhoneNumber("8045342971");
            var call = CallResource.Create(to, from,
                url: new Uri("http://demo.twilio.com/docs/voice.xml"));

            Console.WriteLine(call.Sid);
        }
    }
}
