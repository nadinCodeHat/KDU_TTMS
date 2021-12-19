using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC121271bdeccb935422ce0c46074f451c";
            const string authToken = "f36891ff073a7a2a1ad028953b113e1f";

            TwilioClient.Init(accountSid, authToken);

            string[] numbers = { "+94710680477", "+94712261175", "+94714947346" };

            foreach (string s in numbers)
            {
                var message = MessageResource.Create(
                    body: "Reminder, You have a lecture - Group Project In Software Development(GPSD) at 11:15 for Intake 36. Lecture Hall(LT-B)",
                    from: new Twilio.Types.PhoneNumber("+12513063547"),
                    to: new Twilio.Types.PhoneNumber(s)
                );
                Console.WriteLine(message.Sid);
            }
        }
    }
}
