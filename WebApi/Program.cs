using AddDependencies;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Dal_Repository.Model;
namespace WebApi

{




public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ���� ������ CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder
                        .WithOrigins("http://localhost:4200") // ������� �� ����� ���
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });


            // ����� �������� CORS

            builder.Services.AddDbContext<LearningPlatformContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("myConnection")));
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDependencies();

            var app = builder.Build();
            app.UseCors("AllowSpecificOrigin");
            app.MapControllers();
            app.UseCastommiddleWare();

            // Add EF Core DbContext configuration


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