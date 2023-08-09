namespace wh_Creciendo.Modelo
{
    public class SqlConn
    {
        public static string ObtenerConec()
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration configuration = build.Build();
            string connstring = configuration.GetValue<string>("ConnectionStrings:cnx");
            return connstring;
        }

    }
}
