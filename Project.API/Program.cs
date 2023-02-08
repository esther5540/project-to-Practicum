using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Project.Context;
using Project.Interfaces;
using Project.Repository.Repositories;
using Project.Services.AutoMapper;
using Project.Services.Interfaces;
using Project.Services.Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*").AllowAnyHeader()
                                                  .AllowAnyMethod();
                      });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Mapping));
builder.Services.AddSingleton(typeof(Mapping));

builder.Services.AddScoped<IUsersRepositories, UsersRepositories>();
builder.Services.AddScoped<IUsersServices, UsersServices>();
builder.Services.AddDbContext<IContext, MyDBContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
//const cors = require('cors');
//const corsOptions ={
//    origin:'http://localhost:3000', 
//    credentials: true,            //access-control-allow-credentials:true
//    optionSuccessStatus: 200
//}
//app.use(cors(corsOptions));