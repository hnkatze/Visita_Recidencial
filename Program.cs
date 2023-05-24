using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = "Data Source=localhost,1433; Initial Catalog=VisitaResidentes; user ID=SA; Password=C@m1l1t0*; TrustServerCertificate=True";
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped< ICasaService, CasaService>();
builder.Services.AddScoped<IResidenteService, ResidenteService>();
builder.Services.AddScoped< IVisitaService, VisitaService>();
builder.Services.AddScoped<IVisitanteService, VisitanteService>();
builder.Services.AddScoped<IHabitantesCService, HabitantesCService>();
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
