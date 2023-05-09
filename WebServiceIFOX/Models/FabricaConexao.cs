using MySql.Data.MySqlClient;

namespace WebServiceIFOX.Models
{
    public class FabricaConexao
    {
        public static MySqlConnection getConexao() {
            return new MySqlConnection(
                Configuration().GetConnectionString("Default"));

            //Default
            //casaNepo
        }

        private static IConfigurationRoot Configuration() {
            IConfigurationBuilder builder =
                new ConfigurationBuilder().SetBasePath(
                    Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            return builder.Build();
        }
    }
}

