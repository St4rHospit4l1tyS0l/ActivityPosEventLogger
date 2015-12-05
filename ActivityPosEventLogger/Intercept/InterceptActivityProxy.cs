using ActivityPosEventLogger.Service;
using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    public partial class InterceptActivityProxy : IInterceptAlohaActivity20
    {
        private readonly PosInterceptService _service;

        public InterceptActivityProxy()
        {
            _service = new PosInterceptService();
        }
    }
}
