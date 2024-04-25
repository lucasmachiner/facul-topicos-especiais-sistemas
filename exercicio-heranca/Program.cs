// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Carro carro = new Carro();
carro.Modelo = "Polo";
carro.Marca = "Fiat";
carro.NumeroPortas = 4;
carro.Ligar();

Console.WriteLine("Carro " + carro.Modelo);
Console.WriteLine("Carro " + carro.Marca);
Console.WriteLine("Carro " + carro.NumeroPortas);

Moto moto = new Moto();
moto.Modelo = "CG Fan";
moto.Marca = "Honda";
moto.Cilindradas = 160;
moto.Ligar();

Console.WriteLine("moto " + moto.Modelo);
Console.WriteLine("moto " + moto.Marca);
Console.WriteLine("moto " + moto.Cilindradas);

Caminhao caminhao = new Caminhao();
caminhao.Modelo = "Modelo caminhao";
caminhao.Marca = "Volvo";
caminhao.CapacidadeCarga = 120;
caminhao.Ligar();

Console.WriteLine("caminhao " + caminhao.Modelo);
Console.WriteLine("caminhao " + caminhao.Marca);
Console.WriteLine("caminhao " + caminhao.CapacidadeCarga);