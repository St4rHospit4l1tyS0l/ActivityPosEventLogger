using System.Runtime.InteropServices;
using ActivityPosEventLogger.Infrastructure;
using ActivityPosEventLogger.Service;
using LasaActivity;

namespace ActivityPosEventLogger.Intercept
{
    [Guid("E34E34B8-C661-407D-8D76-174DAA80FF03")]
    public partial class InterceptActivityProxy : IInterceptAlohaActivity20
    {
        private readonly PosInterceptService _service;

        public InterceptActivityProxy()
        {
            Logger.Write("Iniciando InterceptActivityProxy");
            _service = new PosInterceptService();
            Logger.Write("InterceptActivityProxy iniciado");

        }
    }
}
