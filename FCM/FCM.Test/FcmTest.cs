using Xunit;

namespace FCM.Test
{
    public class FcmTest
    {
        private readonly IFcm _fcm;
        public FcmTest()
        {
            _fcm = new FcmBuilder()
                .WithApiKey("Your_API_key")
                .GetFcm();

        }
        [Fact]
        public async void SendMessageAsync()
        {
            await _fcm.SendMessageAsync("/topics/news", "My Message Title", "Message Data", "");
        }
    }
}
