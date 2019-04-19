﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Maxim.Services.Identity.Logger
{
    public static class DbLoggerFactoryExtensions
    {
        public static ILoggingBuilder AddDbLogger(this ILoggingBuilder builder)
        {
            builder.Services.AddSingleton<ILoggerProvider, DbLoggerProvider>();
            return builder;
        }
    }
}