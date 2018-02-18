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
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("simple-attribute-route")]
        public IActionResult SimpleAttributeRoute()
        {
            return Content(nameof(SimpleAttributeRoute));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("simple-attribute-route-async")]
        public Task<IActionResult> SimpleAttributeRouteAsync()
        {
            return Task.FromResult<IActionResult>(Content(nameof(SimpleAttributeRouteAsync)));
        }
        
    }

}
