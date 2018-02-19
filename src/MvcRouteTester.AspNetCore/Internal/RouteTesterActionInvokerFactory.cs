﻿#region License
// Copyright (c) Niklas Wendel 2018
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
#endregion
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Formatters.Json.Internal;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.Extensions.Options;

namespace MvcRouteTester.AspNetCore.Internal
{

    /// <summary>
    /// 
    /// </summary>
    public class RouteTesterActionInvokerFactory : IActionInvokerFactory
    {

        #region Dependencies

        private readonly IOptions<MvcOptions> _mvcOptions;
        private readonly JsonResultExecutor _jsonResultExecutor;
        private readonly ControllerActionInvokerCache _controllerActionInvokerCache;
        private readonly ActionInvokerFactory _actionInvokerFactory;

        #endregion

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mvcOptions"></param>
        /// <param name="jsonResultExecutor"></param>
        /// <param name="controllerActionInvokerCache"></param>
        /// <param name="actionInvokerFactory"></param>
        public RouteTesterActionInvokerFactory(
            IOptions<MvcOptions> mvcOptions, 
            JsonResultExecutor jsonResultExecutor,
            ControllerActionInvokerCache controllerActionInvokerCache,
            ActionInvokerFactory actionInvokerFactory)
        {
            _mvcOptions = mvcOptions;
            _jsonResultExecutor = jsonResultExecutor;
            _controllerActionInvokerCache = controllerActionInvokerCache;
            _actionInvokerFactory = actionInvokerFactory;
        }

        #endregion

        #region Create Invoker

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        public IActionInvoker CreateInvoker(ActionContext actionContext)
        {
            var valueProviderFactories = _mvcOptions.Value.ValueProviderFactories;

            return new RouteTesterActionInvoker(actionContext, valueProviderFactories, _jsonResultExecutor, _controllerActionInvokerCache, _actionInvokerFactory);
        }

        #endregion

    }

}
