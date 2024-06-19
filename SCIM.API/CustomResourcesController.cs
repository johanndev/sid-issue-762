// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using MassTransit;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SimpleIdServer.Scim;
using SimpleIdServer.Scim.Api;
using SimpleIdServer.Scim.Commands.Handlers;
using SimpleIdServer.Scim.Helpers;
using SimpleIdServer.Scim.Persistence;
using SimpleIdServer.Scim.Queries;

namespace SCIM.API
{
    public partial class Program
    {

        public class CustomResourcesController : BaseApiController
        {
            public CustomResourcesController(
                IAddRepresentationCommandHandler addRepresentationCommandHandler,
                IDeleteRepresentationCommandHandler deleteRepresentationCommandHandler,
                IReplaceRepresentationCommandHandler replaceRepresentationCommandHandler,
                IPatchRepresentationCommandHandler patchRepresentationCommandHandler,
                ISearchRepresentationsQueryHandler searchRepresentationsQueryHandler,
                IGetRepresentationQueryHandler getRepresentationQueryHandler,
                IAttributeReferenceEnricher attributeReferenceEnricher,
                IOptionsMonitor<SCIMHostOptions> options,
                ILogger<CustomResourcesController> logger,
                IBusControl busControl,
                IResourceTypeResolver resourceTypeResolver,
                IUriProvider uriProvider,
                IRealmRepository realmRepository) : base(
                    "CustomResources",
                    addRepresentationCommandHandler,
                    deleteRepresentationCommandHandler,
                    replaceRepresentationCommandHandler,
                    patchRepresentationCommandHandler,
                    searchRepresentationsQueryHandler,
                    getRepresentationQueryHandler,
                    attributeReferenceEnricher,
                    options,
                    logger,
                    busControl,
                    resourceTypeResolver,
                    uriProvider,
                    realmRepository)
            { }
        }
    }
}