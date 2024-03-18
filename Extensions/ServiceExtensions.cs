﻿namespace OfixOdaApi.Extensions
{
		public static class ServiceExtensions
		{
				public static void ConfigureCors(this IServiceCollection services)
				{
						services.AddCors(options =>
						{
								options.AddPolicy("CorsPolicy", builder =>
								builder.AllowAnyOrigin()
								.AllowAnyMethod()
								.AllowAnyOrigin());
						});
				}

				//public static void ConfigureCors2(this IServiceCollection services) =>
				//																 services.AddCors(options =>
				//																 {
				//																		 options.AddPolicy("CorsPolicy", builder =>
				//																		 builder.AllowAnyOrigin()
				//																		 .AllowAnyMethod()
				//																		 .AllowAnyHeader());
				//																 });

				public static void ConfigureIISIntegration(this IServiceCollection services) =>
						services.Configure<IISOptions>(options =>
						{

						});

		}
}