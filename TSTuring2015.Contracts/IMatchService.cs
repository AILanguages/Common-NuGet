//-----------------------------------------------------------------------
// <copyright file="IMatchService.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Contracts
{
    using System.ServiceModel;
    using DataContracts;

    [ServiceContract]
    public interface IMatchService
    {
        //demo
        [OperationContract]
        NewMatchResponse GetData(NewMatchRequest usePatternRequest);

        [OperationContract]
        GetScreenResponse GetCurrentScreenModel(GetScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse SelectFor(ChangeScreenRequest userKey);

        [OperationContract]
        CommandResponse Commands(CommandRequest request);

        [OperationContract]
        ChangeScreenResponse MoreGridSenseFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreSenseFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse SelectWordFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreGridDetailFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreChangeDetailFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreDetailFor(ChangeScreenRequest userKey);

        [OperationContract]
        GetTextResponse GetText(GetTextRequest request);
    }
}