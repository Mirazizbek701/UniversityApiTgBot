
using Telegram.Bot;
using TgBotProject.Application.Handlers;

namespace TgBotProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddHttpClient();
            //builder.Services.AddSingleton<IWeatherServices, WeatherServices>();


            TelegramBotClient botClient = new TelegramBotClient(builder.Configuration.GetSection("Tokens")["token"]);

            botClient.StartReceiving(new MessageHandler());

            builder.Services.AddSingleton(botClient);

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