using GoogleMicrosoftAuthenticator;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GoogleMicrosoftAuthenticator.DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
    
builder.Services.AddScoped<GoogleMicrosoftAuthenticator.AuthenticatorService>();
builder.Services.AddIdentity<User,Role>().AddEntityFrameworkStores<GoogleMicrosoftAuthenticator.DbContext>().AddDefaultTokenProviders();

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
