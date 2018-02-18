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
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcRouteTester.AspNetCore.Builders
{

    /// <summary>
    /// 
    /// </summary>
    public interface IRouteAssertBuilder
    {

        #region Maps To

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TController"></typeparam>
        /// <param name="actionCallExpression"></param>
        /// <returns></returns>
        IRouteAssertBuilder MapsTo<TController>(Expression<Func<TController, IActionResult>> actionCallExpression)
            where TController : Controller;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TController"></typeparam>
        /// <param name="actionCallExpression"></param>
        /// <returns></returns>
        IRouteAssertBuilder MapsTo<TController>(Expression<Func<TController, Task<IActionResult>>> actionCallExpression)
            where TController : Controller;

        #endregion

    }

}
