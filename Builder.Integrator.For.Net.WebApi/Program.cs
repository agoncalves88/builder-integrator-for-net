using Builder.Integrator.For.Net.Acl;
using Builder.Integrator.For.Net.CrossCutting;
using Builder.Integrator.For.Net.Domain.Interface.Acl;
using Builder.Integrator.For.Net.Domain.Interface.Services;
using Builder.Integrator.For.Net.Domain.Services;
//using builder_integrator_for_net.CrossCutting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IIntegratorService, IntegratorService>();
builder.Services.AddScoped<IApiIntegratorAcl, ApiIntegratorAcl>();

builder.Services.Configure<DataSourceConfigOptions>(builder.Configuration.GetSection(DataSourceConfigOptions.DataSourcesConfigOptions));


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
