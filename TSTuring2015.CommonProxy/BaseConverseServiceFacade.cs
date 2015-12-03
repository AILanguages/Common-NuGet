//-----------------------------------------------------------------------
// <copyright file="BaseConverseServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using Contracts;

    public abstract class BaseConverseServiceFacade
    {
        protected readonly IConverseService ConverseService;

        protected BaseConverseServiceFacade(IConverseService converseService)
        {
            ConverseService = converseService;
        }
    }
}