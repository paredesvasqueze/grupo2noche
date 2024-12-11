using FrontEnd.Servicio;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("EstaEsUnaClaveMuySeguraYDeAlMenos32Caracteres")) // clave secreta simulada
    };
});


/*

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
*/

builder.Services.AddAuthorization();

builder.Services.AddHttpClient<TokenService>();
builder.Services.AddScoped<TokenService>();
//builder.Services.AddControllersWithViews();
//builder.Services.AddHttpClient<ICategoriaService, CategoriaService>();
builder.Services.AddHttpClient<CategoriaService>();
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddHttpClient<ProductoService>();
builder.Services.AddScoped<ProductoService>();
builder.Services.AddHttpClient<RolService>();
builder.Services.AddScoped<RolService>();
builder.Services.AddHttpClient<AreaDeEstudioService>();
builder.Services.AddScoped<AreaDeEstudioService>();
builder.Services.AddHttpClient<GeneroService>();
builder.Services.AddScoped<GeneroService>();
builder.Services.AddHttpClient<LibroService>();
builder.Services.AddScoped<LibroService>();
builder.Services.AddHttpClient<ComentarioService>();
builder.Services.AddScoped<ComentarioService>();
builder.Services.AddHttpClient<AutorService>();
builder.Services.AddScoped<AutorService>();
builder.Services.AddHttpClient<ArticuloService>();
builder.Services.AddScoped<ArticuloService>();
builder.Services.AddHttpClient<PublicacionService>();
builder.Services.AddScoped<PublicacionService>();
builder.Services.AddHttpClient<PublicacionAutorService>();
builder.Services.AddScoped<PublicacionAutorService>();
builder.Services.AddHttpClient<UsuarioService>();
builder.Services.AddScoped<UsuarioService>();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseSession();
//app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
