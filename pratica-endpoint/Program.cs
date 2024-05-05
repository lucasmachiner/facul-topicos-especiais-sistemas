using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("imposto", async (HttpContext context) =>
{
  using var reader = new System.IO.StreamReader(context.Request.Body);

  var body = await reader.ReadToEndAsync();

  var json = JsonDocument.Parse(body);

  var produto = json.RootElement.GetProperty("produto").ToString();
  var preco = json.RootElement.GetProperty("preco").ToString();
  var imposto = json.RootElement.GetProperty("imposto").ToString();

  float calc = float.Parse(imposto) * float.Parse(preco);


  return "O valor do imposto sobre o produto: " + calc.ToString("n2");
});

app.Run();
