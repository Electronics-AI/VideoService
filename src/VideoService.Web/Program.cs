var builder = WebApplication.CreateBuilder(args);

// Extensions.Host

// builder.Host

// Extensions.Service
builder.Services.AddControllers();


// Middleware
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
