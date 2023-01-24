using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;
using Newtonsoft.Json;  
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IGetInsuranceData, GetInsuranceData>();

var app = builder.Build();



// Configure the HTTP request pipeline.


    app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
 