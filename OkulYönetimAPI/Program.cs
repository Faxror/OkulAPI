using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.DataAccess.Concrete;
using OkulYönetimAPI.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IStudentService, StudentManager>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<StudentRepository>();

builder.Services.AddScoped<ISchoolService, SchoolManager>();
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddScoped<SchoolRepository>();

builder.Services.AddScoped<ITeacherService, TeacherManager>();
builder.Services.AddScoped<ITeachersRepository, TeacherRepository>();
builder.Services.AddScoped<TeacherRepository>();

builder.Services.AddScoped<ILessonsService, LessonsManager>();
builder.Services.AddScoped<ILessonsRepository, LessonsRepository>();
builder.Services.AddScoped<LessonsRepository>();


builder.Services.AddScoped<IHomeworkandExamsService, HomeworksandExams>();
builder.Services.AddScoped<IHomeWorksandExamsRepository, HomeworksandExamsRepository>();
builder.Services.AddScoped<HomeworksandExamsRepository>();

builder.Services.AddScoped<ILoginService, LoginManager>();
builder.Services.AddScoped<ILoginAndRegisterRepository, LoginAndRegisterRepository>();
builder.Services.AddScoped<LoginAndRegisterRepository>();

builder.Services.AddDbContext<SchoolDBContext>();

builder.Services.AddSwaggerGen(c => {
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
