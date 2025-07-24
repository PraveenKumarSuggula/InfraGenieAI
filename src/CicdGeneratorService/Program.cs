
using CicdGeneratorService.Data;
using CicdGeneratorService.Services;
using Microsoft.Azure.Cosmos;

namespace CicdGeneratorService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            builder.Services.AddControllers();
            builder.Services.AddHttpClient<IOpenAiService, OpenAiService>();

            // EF Core: Add DB Context
            builder.Services.AddSingleton(s => 
            new CosmosClient(builder.Configuration["CosmosDB:ConnectionString"]));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseCors("AllowFrontend");

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
