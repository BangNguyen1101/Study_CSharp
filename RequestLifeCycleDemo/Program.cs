using RequestLifeCycleDemo;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ================= Cấu hình Swagger + Token =================
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RequestLifeCycleDemo", Version = "v1" });

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

var app = builder.Build();

// ================= Pipeline =================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
