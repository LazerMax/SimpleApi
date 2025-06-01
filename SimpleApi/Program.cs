var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку контроллеров
builder.Services.AddControllers();

var app = builder.Build();

// Включите HTTPS и маршрутизацию
//app.UseHttpsRedirection();
app.MapControllers();

app.Run();