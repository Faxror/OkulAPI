using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddScoped<IStudentService, StudentManager>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<StudentRepository>();
builder.Services.AddDbContext<SchoolDBContext>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
