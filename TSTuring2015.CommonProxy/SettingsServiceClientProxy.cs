//-----------------------------------------------------------------------
// <copyright file="DemoServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using Contracts;
    using DataContracts;

    public class SettingsServiceClientProxy : AbstractServiceClientFactory<ISettingsService>, ISettingsService
    {
        public ChangeSettingsResponse SetSettings(ChangeSettingsRequest request)
        {
            return Channel.SetSettings(request);
        }

        public GetSettingsResponse GetSettings(GetSettingsRequest request)
        {
            return Channel.GetSettings(request);
        }

        public ChangeSampleSettingsResponse SetSampleSettings(ChangeSampleSettingsRequest request)
        {
            return Channel.SetSampleSettings(request);
        }

        public GetSampleSettingsResponse GetSampleSettings(GetSampleSettingsRequest request)
        {
            return Channel.GetSampleSettings(request);
        }
    }
}