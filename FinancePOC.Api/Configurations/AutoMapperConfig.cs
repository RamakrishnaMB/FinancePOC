﻿using AutoMapper;
using FinancePOC.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancePOC.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(Application.AutoMapper.AutoMapperConfiguration));
            //AutoMapperConfiguration.RegisterMappings();

            AutoMapperConfiguration.ConfigureAtApplicationStart();
        }
    }
}
