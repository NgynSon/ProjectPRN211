using Microsoft.Extensions.Configuration;

namespace Repository
{
    public class ConnectionString
    {
         public static string GetConnectionString()
            {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:MyContext"];

            return strConn;
        }

    }

    //dotnet ef dbcontext scaffold "Server=(local);uid=sa;pwd=sa123;database=PetShopDB;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models
}