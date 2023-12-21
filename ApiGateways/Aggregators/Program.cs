using Aggregators.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();
builder.Services.AddScoped<IGreeterService, GreeterService>();
builder.Services.AddGrpcClient<GreetApi.Greeter.GreeterClient>(options =>
{
    options.Address = new Uri("http://sample-api");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

//using Aggregators.Services;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.OpenApi.Models;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddHttpClient();
//builder.Services.AddScoped<IGreeterService, GreeterService>();
//builder.Services.AddGrpcClient<GreetApi.Greeter.GreeterClient>(options =>
//{
//    options.Address = new Uri("http://sample-api:81");
//});


//var app = builder.Build();

//app.UseSwagger();
//app.UseSwaggerUI(options =>
//{
//    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//    options.RoutePrefix = string.Empty;
//});

////// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.UseSwagger();
////    app.UseSwaggerUI();
////}

//app.MapGet("/", () => "Hello World!");

//app.Run();