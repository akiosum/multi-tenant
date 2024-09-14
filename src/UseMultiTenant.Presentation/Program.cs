using UseMultiTenant.Presentation.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AdicionarConfiguracoes(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();