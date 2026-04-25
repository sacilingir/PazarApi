using PazarApi.Persistence;
namespace PazarApi.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            var env = builder.Environment;
            builder.Configuration.SetBasePath(env.ContentRootPath) //Uygulamaya, ayar dosyalarýný nerede arayacaðýný söyler Projenin ana kök dizininde ara).
                .AddJsonFile("appsettings.json", optional: false) //Sisteme önce ana (ortak) ayar dosyasýný yüklemesini söyler. Buradaki optional: false parametresi çok kritiktir. Bu, dosyanýn zorunlu olduðunu belirtir. Eðer proje klasöründe appsettings.json dosyasý yoksa, uygulama ayaða kalkmaz ve hata verip çöker.
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true); //Sihrin gerçekleþtiði yer burasýdýr! Koddaki {env.EnvironmentName} kýsmý, o anki ortama göre dinamik olarak dolacaktýr (Örn: appsettings.Development.json). Sistem önce ana dosyayý okur, sonra gelip bu ortama özel dosyayý okuyarak mevcut ayarlarý ezer/günceller.

            builder.Services.AddPersistence(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
