﻿using mobSocial.Core.Infrastructure.AppEngine;
using Owin;

namespace mobSocial.WebApi.Configuration.Middlewares
{
    /// <summary>
    /// Middleware for registering various picture sizes
    /// </summary>
    public static class PictureSizeRegistrar
    {
        public static void UsePictureSizeRegistrar(this IAppBuilder app)
        {
            app.Use(async (context, next) =>
            {
                mobSocialEngine.SetupPictureSizes();
                await next();
            });
        }  
    }
}