﻿using BlazorAdmin.Services.CatalogItemServices;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.eShopWeb.Web.Configuration
{
    public static class BlazorServicesConfiguration
    {
        public static IServiceCollection AddBlazorServices(this IServiceCollection service)
        {
            service.AddScoped<Create>();
            service.AddScoped<ListPaged>();
            service.AddScoped<Delete>();
            service.AddScoped<Edit>();
            service.AddScoped<GetById>();

            service.AddScoped<BlazorAdmin.Services.CatalogBrandServices.List>();
            service.AddScoped<BlazorAdmin.Services.CatalogTypeServices.List>();

            return service;
        }
    }
}
