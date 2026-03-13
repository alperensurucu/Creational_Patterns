
namespace Singleton_Design_Pattern_CSharp_AspNetCore_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
             app.UseSwagger();
             app.UseSwaggerUI();

            app.MapControllers();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run();
        }
    }
}
