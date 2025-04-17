var builder = WebApplication.CreateBuilder(args);

// Config dosyas�ndan ba�lant� al�n�yor
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
app.MapControllers(); // <-- Buras� olmazsa controller'lar �al��maz

app.Run();