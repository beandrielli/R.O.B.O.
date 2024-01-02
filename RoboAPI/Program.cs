using Microsoft.AspNetCore.Cors.Infrastructure;
using ROBO.Infra;
using ROBO.Infra.Interfaces;
using ROBO.Servicos;

string _corsPolicy = "__cors_policy__";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Por questão de ser um teste estou permitindo qualquer origem acessar a API.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: _corsPolicy,
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                       .AllowAnyMethod()
                                       .AllowAnyHeader();
                      });
});

builder.Services.RegistrarDependenciasInfra();
builder.Services.RegistrarDependenciasServicos();
builder.Services.AddControllers();
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
app.UseCors(_corsPolicy);
app.UseAuthorization();

app.MapControllers();

app.Run();
