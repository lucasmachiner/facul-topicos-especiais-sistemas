using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/seunome", () => "Lucas Machiner");

app.MapPost("consultarCPF", async (HttpContext context) =>
{

  using var reader = new System.IO.StreamReader(context.Request.Body);

  var body = await reader.ReadToEndAsync();

  //Deserializar(decompor) o objeto JSOn que esta no body
  var json = JsonDocument.Parse(body);

  var cpf = json.RootElement.GetProperty("cpf").ToString();
  var nome = "";

  if (cpf == "888")
  {
    nome = "Pedro de Lara";
  }
  else if (cpf == "999")
  {
    nome = "Arice de Almeida";
  }
  else
  {
    nome = "Desconhecido";
  }

  return "nome " + nome;

});

app.Run();
