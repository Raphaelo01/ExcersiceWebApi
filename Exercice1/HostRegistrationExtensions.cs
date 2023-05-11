using ONIS.Shared.Logger;

namespace Exercice1;

public static class HostRegistrationExtensions
{
    public static IHostBuilder RegisterHostConfigurations(this IHostBuilder host)
    {
        //Add serilog Configuration 
        host.ConfigureSerilog();
        return host;
    }
}
