//-----------------------------------------------------------------------
// <copyright file="ISessionService.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Contracts
{
    using System.ServiceModel;
    using DataContracts;

    [ServiceContract(Namespace = "http://demo.thinkingsolutions.co/")]
    public interface ISessionService
    {
        [OperationContract]
        GetIDResponse GetID(GetIDRequest usePatternRequest);
    }
}