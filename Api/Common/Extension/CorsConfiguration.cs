namespace Api.Common.Extension;

public static class CorsConfiguration
{
    public static void AddCorsConfiguration(this IServiceCollection services, string policyName)
    {
        services.AddCors(p => p.AddPolicy(policyName, builder =>
        {
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }));
    }
}
