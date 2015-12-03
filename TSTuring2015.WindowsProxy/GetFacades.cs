//-----------------------------------------------------------------------
// <copyright file="GetFacades.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.WindowsProxy
{
    using CommonProxy;
    using Facades;

    public class GetFacades
    {
        private readonly string _service;

        public GetFacades(string service)
        {
            _service = service; // add :8080     as needed, such as for localhost or when hosting service specifies that port. Azure coded to port 80.

            // the creation of this sets the userkey for server-side tracking of this client
            BaseServiceFacade.SetUpFacade(new SessionServiceClientProxy().Create($"http://{service}/SessionService.svc"));
        }

        public TranslateServiceFacade GetTranslateServiceFacade()
        {
            return new TranslateServiceFacade(new TranslateServiceClientProxy().Create($"http://{_service}/TranslateService.svc"));
        }

        public SettingsServiceFacade GetSettingsServiceFacade()
        {
            return new SettingsServiceFacade(new SettingsServiceClientProxy().Create($"http://{_service}/SettingsService.svc"));
        }

        public ConverseServiceFacade GetConverseSericeFacade()
        {
            return new ConverseServiceFacade(new ConverseServiceClientProxy().Create($"http://{_service}/ConverseService.svc"));
        }
    }
}