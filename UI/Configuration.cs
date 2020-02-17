using Microsoft.Extensions.Configuration;

namespace UI
{
    public class Configuration
    {
        public static IConfiguration ConfigurationInstance;
        public static string EpamHost;

        public static void Configure()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appConfig.json");
            ConfigurationInstance = builder.Build();

            EpamHost = ConfigurationInstance.GetSection("EpamHost").Value;
        }
    }
}
