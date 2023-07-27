using Common.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterDbContext(builder.Configuration);
builder.Services.RegiserRepoService();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
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
app.UseCors(c =>
{
    c.AllowAnyOrigin();
    c.AllowAnyMethod();
    c.AllowAnyHeader();
}
);
app.Run();
