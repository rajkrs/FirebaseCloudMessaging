using Xunit;

namespace FCM.Test
{
    public class FcmTest
    {
        private readonly IFcm _fcm;
        public FcmTest()
        {
            _fcm = new FcmBuilder()
                .WithApiKey("AIzaSyB9qaLmZwt3RjwLfjXl6UNn9wO2t7ySHb8Raj")
                .GetFcm();

        }
        [Fact]
        public async void SendMessageAsync()
        {
            await _fcm.SendMessageAsync("/topics/news", "My Message Title", "Message Data", "");
        }
    }
}
