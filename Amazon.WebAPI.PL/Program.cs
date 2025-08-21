
using Amazon.Application.BL.Contracts;
using Amazon.Application.BL.Services;
using Amazon.DL.Contracts;
using Amazon.DL.Repositories;

namespace Amazon.WebAPI.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register our custom services to Dependency Injection Container
            // to let CLR (.NET Runtime Environment) Generate it for us when need it
            builder.Services.AddScoped<IProductService,ProductService>();
            builder.Services.AddScoped<IProductRepository,ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
