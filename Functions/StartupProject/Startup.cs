using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace StartupProject;
public class Startup : FunctionsStartup
{
	public override void Configure(IFunctionsHostBuilder builder)
	{
		// Services int
		builder.Services.AddSingleton<IOpenApiConfigurationOptions>(_ =>
		{
			var options = new OpenApiConfigurationOptions()
			{
				Info = new OpenApiInfo()
				{
					Version = "1.0.0",
					Title = "Test Swagger",
				},
				Servers = DefaultOpenApiConfigurationOptions.GetHostNames(),
				OpenApiVersion = OpenApiVersionType.V3,
				IncludeRequestingHostName = true,
				ForceHttps = false,
				ForceHttp = false,
			};

			return options;
		});
	}
}
