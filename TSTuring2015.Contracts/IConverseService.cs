//-----------------------------------------------------------------------
// <copyright file="IConverseService.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Contracts
{
    using System.ServiceModel;
    using DataContracts;

    [ServiceContract(Namespace = "http://demo.thinkingsolutions.co/")]
    public interface IConverseService
    {
        //demo
        [OperationContract]
        ConverseResponse GetConversationData(NewMatchRequest usePatternRequest);

        [OperationContract]
        ConverseResponse GetContext(NewMatchRequest usePatternRequest);

        [OperationContract]
        ConverseResponse RestartConversation(NewMatchRequest usePatternRequest);        
    }
}