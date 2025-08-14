using RequestLifeCycleDemo;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using RequestLifeCycleDemo.Models;


var builder = WebApplication.CreateBuilder(args);

// ================= Cấu hình Swagger + Token =================
builder.Services.AddSwaggerGen(c =>
{
   

    // Cấu hình nhập Authorization: Bearer token
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Nhập token dạng: Bearer {token}",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// ================= Cấu hình CORS =================
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// ================= Thêm Controller + Filter toàn cục =================
builder.Services.AddControllers(options =>
{
    options.Filters.Add<MyAuthorizationFilter>();
    options.Filters.Add<MyResourceFilter>();
    options.Filters.Add<MyActionFilter>();
    options.Filters.Add<MyExceptionFilter>();
    options.Filters.Add<MyResultFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<TestProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// ================= Pipeline =================
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
