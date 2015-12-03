//-----------------------------------------------------------------------
// <copyright file="ISettingsService.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Contracts
{
    using System.ServiceModel;
    using DataContracts;

    [ServiceContract(Namespace = "http://demo.thinkingsolutions.co/")]
    public interface ISettingsService
    {
        [OperationContract]
        ChangeSettingsResponse SetSettings(ChangeSettingsRequest request);

        [OperationContract]
        GetSettingsResponse GetSettings(GetSettingsRequest request);

        [OperationContract]
        ChangeSampleSettingsResponse SetSampleSettings(ChangeSampleSettingsRequest request);

        [OperationContract]
        GetSampleSettingsResponse GetSampleSettings(GetSampleSettingsRequest request);
    }
}