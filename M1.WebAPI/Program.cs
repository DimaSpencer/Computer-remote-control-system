using M1.Application.Common.Mapping;
using M1.Application.Extensions;
using M1.Application.Interfaces.Db;
using M1.Persistance;
using M1.WebAPI.Middlewares;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(configuration =>
{
    configuration.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    configuration.AddProfile(new AssemblyMappingProfile(typeof(IAppDbContext).Assembly));
});

builder.Services.AddM1Application();
builder.Services.AddPersistence(builder.Configuration["ConnectionStrings:Database"]);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRequestExceptionHandler();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();