using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCIM.API
{
    [Route("ActionDescriptors")]
    public class ActionDescriptorsController(IActionDescriptorCollectionProvider provider) : Controller
    {
        [HttpGet]
        public IActionResult Get() {
            var res = provider.ActionDescriptors.Items.Select(i => i.DisplayName);
            return new OkObjectResult(res);
        }
    }
}
