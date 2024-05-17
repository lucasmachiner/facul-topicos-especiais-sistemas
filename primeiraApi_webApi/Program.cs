// adicionar o pacote pelo terminal "dotnet add package Microsoft.AspNetCore.Authentication"
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("abc"))
        };
    });

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

////TODO -> commitar essas duas linhas
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

// TODO -> commitar as integrações com o swagger
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

// app.UseHttpsRedirection();


app.MapPost("/login", async (HttpContext context) =>
{
    using var reader = new StreamReader(context.Request.Body);
    var body = await reader.ReadToEndAsync();

    var json = JsonDocument.Parse(body);
    var username = json.RootElement.GetProperty("username").GetString();
    var email = json.RootElement.GetProperty("email").GetString();
    var senha = json.RootElement.GetProperty("senha").GetString();

    var token = "";
    if (senha == "1029")
    {
        token = GenerateToken(email);
    }
    //return token;
    context.Response.WriteAsync(token);
});

//Rota segura: toda rota tem corpo de codigo parecido
app.MapGet("/rotaSegura", async (HttpContext context) =>
{
    //Verificar se o token está valido
    if (!context.Request.Headers.ContainsKey("Authorization"))
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
    }
    await context.Response.WriteAsync("Token não fornecido");

    //Obter token
    var token = context.Request.Headers["Authentication"].ToString().Replace("Bearer ", "");

    //Validar o token
    // Esta logica sera convertida em um metodo dentro de uma classe a ser reaproveitada
    
    var tokenHandler = new JwtSecurityTokenHandler();
    var key = Encoding.ASCII.GetBytes("abcabcabcabcabcabcabcabcabcabcabcabc");
    var validationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
    SecurityToken ValidateToken;

    try
    {
        tokenHandler.ValidateToken(token, validationParameters, out ValidateToken);
    }
    catch(Exception e) {
        //Caso o token seja invalido
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsync("Token inválido");
    }

    await context.Response.WriteAsync("Autorizado");
    return "";

});

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.UtcNow.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

//Metodo generateToken que sera transferido para dentro de uma classe especuaizada
string GenerateToken(string data)
{
    var tokenHandler = new JwtSecurityTokenHandler();
    var secretKey = Encoding.ASCII.GetBytes("abcabcabcabcabcabcabcabcabcabcabcabc"); //Esta chave sera gravada em uma variavel de ambiente
    var tokenDecriptor = new SecurityTokenDescriptor
    {
        Expires = DateTime.UtcNow.AddHours(1),
        SigningCredentials = new SigningCredentials(
            new SymmetricSecurityKey(secretKey),
            SecurityAlgorithms.HmacSha256Signature
        )
    };

    var token = tokenHandler.CreateToken(tokenDecriptor);

    return tokenHandler.WriteToken(token); //Converte para string
}

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
