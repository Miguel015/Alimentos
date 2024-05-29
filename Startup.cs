using PCMarketIA.Models;
using Microsoft.Extensions.Configuration;
using PCMarketIA.Services;

namespace PCMarketIA
{
	public class Startup
	{
		private readonly IWebHostEnvironment _env;
		private readonly IConfiguration _config;

		public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
		{
			_env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
			_config = config ?? throw new ArgumentNullException(nameof(config));
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<MercadoPagoSettings>(_config.GetSection("MercadoPago"));
			services.AddHttpClient("MercadoPagoClient");
			services.AddTransient<MercadoPagoService>();
			services.AddUmbraco(_env, _config)
				.AddBackOffice()
				.AddWebsite()
				.AddComposers()
				.Build();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
            app.UseUmbraco()
				.WithMiddleware(u =>
				{
					u.UseBackOffice();
					u.UseWebsite();
				})
				.WithEndpoints(u =>
				{
					u.UseInstallerEndpoints();
					u.UseBackOfficeEndpoints();
					u.UseWebsiteEndpoints();
				});
		}
	}
}
