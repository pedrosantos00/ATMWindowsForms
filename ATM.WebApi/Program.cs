using ATM.DAL;
using ATM.Logic;

namespace ATM.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<ATMDbContext>();
            builder.Services.AddScoped<BankRepository>();
            builder.Services.AddScoped<BankService>();
            builder.Services.AddScoped<TransactionRepository>();
            builder.Services.AddScoped<TransactionService>();
            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<UserService>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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