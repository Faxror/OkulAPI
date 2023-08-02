using OkulY�netimAPI.Business.Abstrack;
using OkulY�netimAPI.Business.Concrete;
using OkulY�netimAPI.DataAccess;
using OkulY�netimAPI.DataAccess.Abstrack;
using OkulY�netimAPI.DataAccess.Concrete;

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
