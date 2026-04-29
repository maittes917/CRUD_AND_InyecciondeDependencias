using MisGastosApi.Services;

var builder = WebApplication.CreateBuilder(args);

//  Inyección de dependencias
builder.Services.AddScoped<IGastoService, GastoService>();

// Servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();