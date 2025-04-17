var builder = WebApplication.CreateBuilder(args);

// Config dosyasýndan baðlantý alýnýyor
builder.Services.AddControllers();

// Swagger (Opsiyonel)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // <-- Burasý olmazsa controller'lar çalýþmaz

app.Run();