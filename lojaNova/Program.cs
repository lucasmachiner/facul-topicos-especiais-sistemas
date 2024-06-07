using Microsoft.EntityFrameworkCore;
using loja.Data;
using loja.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<LojaDbContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36))));

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("/createProduto", async (LojaDbContext dbContext, Produto newProduto) =>
{
    dbContext.Produtos.Add(newProduto);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/createProduto/{newProduto.Id}", newProduto);
});

app.MapGet("/Produtos", async (LojaDbContext dbContext) =>
{

    var produtos = await dbContext.Produtos.ToListAsync();
    return Results.Ok(produtos);
});

app.MapGet("/ProdutoId/{id}", async (int id, LojaDbContext dbContext) =>
{


    var produtos = await dbContext.Produtos.FindAsync(id);

    if(produtos == null)
    {
        return Results.NotFound($"Product with ID {id} not found");
    }
    return Results.Ok(produtos);
});

app.MapPut("/updateProduto/{id}", async (int id, LojaDbContext dbContext, Produto updateProduto) =>
{

    var existingProduto = await dbContext.Produtos.FindAsync(id);

    if (existingProduto == null)
    {
        return Results.NotFound($"Product with ID {id} not found");
    }

    existingProduto.Nome = updateProduto.Nome;
    existingProduto.Preco = updateProduto.Preco;
    existingProduto.Fornecedor = updateProduto.Fornecedor;

    await dbContext.SaveChangesAsync();
    
    return Results.Ok(existingProduto);
});

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

app.Run();
