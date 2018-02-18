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

namespace MvcRouteTester.AspNetCore.Internal
{

    /// <summary>
    /// 
    /// </summary>
    public class RouteExpressionParser
    {

        #region Parse

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionCallExpression"></param>
        /// <returns></returns>
        public ActionInvokeInfo Parse(LambdaExpression actionCallExpression)
        {
            var methodCallExpression = GetInstanceMethodCallExpression(actionCallExpression);
            var methodInfo = methodCallExpression.Method;

            var result = new ActionInvokeInfo
            {
                ControllerTypeAssemblyQualifiedName = methodInfo.ReflectedType.AssemblyQualifiedName,
                ActionMethodName = methodInfo.Name
            };
            return result;
        }

        #endregion

        #region Get Instance Method Call Expression

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionCallExpression"></param>
        /// <returns></returns>
        private static MethodCallExpression GetInstanceMethodCallExpression(LambdaExpression actionCallExpression)
        {
            if (!(actionCallExpression.Body is MethodCallExpression methodCallExpression))
            {
                throw new ArgumentException("Not a method call expression", nameof(actionCallExpression));
            }
            var objectInstance = methodCallExpression.Object;
            if (objectInstance == null)
            {
                throw new ArgumentException("Not an instance method call expression", nameof(actionCallExpression));
            }

            return methodCallExpression;
        }

        #endregion

    }

}