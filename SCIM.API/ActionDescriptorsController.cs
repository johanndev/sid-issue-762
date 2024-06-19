using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SimpleIdServer.Scim.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCIM.API
{
    [Route("routedebug")]
    public class ActionDescriptorsController(
        IActionDescriptorCollectionProvider provider,
        IScimEndpointStore scimEndpointStore
        ) : Controller
    {
        [HttpGet("actiondescriptors")]
        public IActionResult GetActionDescriptors() {
            var res = provider.ActionDescriptors.Items.Select(i => i.DisplayName);
            return new OkObjectResult(res);
        }

        [HttpGet("scimendpoints")]
        public IActionResult Get()
        {
            var res = scimEndpointStore.Routes.Select(r => r.RouteName);
            return new OkObjectResult(res);
        }
    }

}
