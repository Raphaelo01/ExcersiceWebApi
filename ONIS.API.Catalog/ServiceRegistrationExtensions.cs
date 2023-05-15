namespace ONIS.API.Catalog;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection RegisterBusinessServices(
           this IServiceCollection services)
    {

        return services;
    }

    public static IServiceCollection RegisterDataServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        // add the DbContext
        // add the DbContext
        services.AddDbContext<CatalogDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CatalogDB")));

        //RegisterBusiness
        services.AddScoped<IProductService, ProductService>();
        // register the repository
        services.AddScoped<IProductCatalogRepository, ProductCatalogRepository>();

        //AddSerilog
        services.AddLogging(logger => logger.AddSerilog());




        return services;
    }
}
