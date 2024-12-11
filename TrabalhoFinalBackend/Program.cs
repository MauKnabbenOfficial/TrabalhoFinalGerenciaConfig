//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigin", policy =>
//    {
//        policy.WithOrigins("http://localhost:5173")
//              .AllowAnyHeader()
//              .AllowAnyMethod();
//    });
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//// Habilitando CORS
//app.UseCors("AllowSpecificOrigin");

//app.MapControllers();

//app.Run();

var builder = WebApplication.CreateBuilder(args);

// Configurando o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
var app = builder.Build();

// Habilitando CORS
//app.UseCors("AllowSpecificOrigin");

app.MapControllers();

app.Run();
