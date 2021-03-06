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
using Xunit;
using MvcRouteTester.AspNetCore.Builders;

namespace MvcRouteTester.AspNetCore.Tests.Builders
{

    /// <summary>
    /// 
    /// </summary>
    public class RouteTesterMapsToRouteAssertTests
    {

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ThrowsOnForParameterNullParameterName()
        {
            var tested = new RouteTesterMapsToRouteAssert(null, null, null);

            Assert.Throws<ArgumentNullException>("parameterName", () =>
                tested.ForParameter<string>(null, p => { }));
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ThrowsOnForParameterNullAction()
        {
            var tested = new RouteTesterMapsToRouteAssert(null, null, null);

            Assert.Throws<ArgumentNullException>("action", () =>
                tested.ForParameter<string>("parameter", null));
        }
        
    }

}
