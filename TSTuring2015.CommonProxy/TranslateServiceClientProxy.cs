//-----------------------------------------------------------------------
// <copyright file="TranslateServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using Contracts;
    using DataContracts;

    public class TranslateServiceClientProxy : AbstractServiceClientFactory<ITranslateService>, ITranslateService
    {
        public NewMatchResponse GetData(NewMatchRequest usePatternRequest)
        {
            return Channel.GetData(usePatternRequest);
        }

        public GetTextResponse GetText(GetTextRequest request)
        {
            return Channel.GetText(request);
        }

        public GetScreenResponse GetCurrentScreenModel(GetScreenRequest userKey)
        {
            return Channel.GetCurrentScreenModel(userKey);
        }
    }
}