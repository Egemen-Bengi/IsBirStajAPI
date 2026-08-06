using IsBirStajAPI.Data;
using IsBirStajAPI.Interfaces;
using IsBirStajAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Veritabanı Bağlantısı (SQLite)
// envanter.db dosyasının Program.cs ile aynı dizinde olduğunu varsayıyoruz
builder.Services.AddDbContext<EnvanterContext>(options =>
    options.UseSqlite("Data Source=envanter.db"));

// 3. Servislerin (Dependency Injection) Kaydı
builder.Services.AddScoped<IDonanımRepositry, DonanımRepository>();

// 4. Controller Desteği (Mobil uygulamanın bağlanacağı uç noktalar için)
builder.Services.AddControllers();

// OpenAPI ve Swagger Konfigürasyonları (Test edebilmek için)
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(); // Tarayıcıda API'yi görsel olarak test edebilmeni sağlar
}

app.UseHttpsRedirection();

// 5. Gelen HTTP isteklerini Controller'lara yönlendir
app.MapControllers();

app.Run();