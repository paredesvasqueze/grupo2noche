using CapaDatos;
using CapaDomain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// Cargar la configuración desde appsettings.json
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Registrar el patrón Singleton para la conexión a la base de datos
builder.Services.AddSingleton(provider =>
    ConexionSingleton.GetInstance(provider.GetRequiredService<IConfiguration>()));

// Registrar el repositorio y la capa de dominio

builder.Services.AddScoped<AlumnoRepository>();
builder.Services.AddScoped<AlumnoDomain>();

builder.Services.AddScoped<RolRepository>();
builder.Services.AddScoped<RolDomain>();

builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<UsuarioDomain>();

builder.Services.AddScoped<LibroRepository>();
builder.Services.AddScoped<LibroDomain>();

builder.Services.AddScoped<PublicacionRepository>();
builder.Services.AddScoped<PublicacionDomain>();

builder.Services.AddScoped<InvestigacionRepository>();
builder.Services.AddScoped<InvestigacionDomain>();

builder.Services.AddScoped<ArticuloRepository>();
builder.Services.AddScoped<ArticuloDomain>();

builder.Services.AddScoped<GeneroRepository>();
builder.Services.AddScoped<GeneroDomain>();

builder.Services.AddScoped<ComentarioRepository>();
builder.Services.AddScoped<ComentarioDomain>();

builder.Services.AddScoped<AutorRepository>();
builder.Services.AddScoped<AutorDomain>();

builder.Services.AddScoped<PublicacionAutorRepository>();
builder.Services.AddScoped<PublicacionAutorDomain>();

builder.Services.AddScoped<AreaDeEstudioRepository>();
builder.Services.AddScoped<AreaDeEstudioDomain>();

// Registrar los controladores
builder.Services.AddControllers();

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
