//-----------------------------------------------------------------------
// <copyright file="ISamplesService.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Contracts
{
    using System.ServiceModel;
    using DataContracts;

    [ServiceContract(Namespace = "http://demo.thinkingsolutions.co/")]
    public interface ISamplesService
    {
        //samples
        [OperationContract]
        SampleMatchResponse GetHomePageView(SampleMatchRequest request);

        [OperationContract]
        ChooseSampleFileResponse ChooseSampleFileFor(ChooseSampleFileRequest request);

        [OperationContract]
        ChangeScreenResponse SelectSampleFor(ChangeScreenRequest request);

        [OperationContract]
        ChangeScreenResponse EditSampleFor(ChangeScreenRequest request);
    }
}