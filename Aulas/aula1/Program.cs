// See https://aka.ms/new-console-template for more information

cliente objCliente = new cliente();
objCliente.nomeCompleto = "Lucas Machiner";
objCliente.cpf = "8885588";
objCliente.idade = 18;


Console.WriteLine(objCliente.nomeCompleto);
Console.WriteLine(objCliente.cpf);

objCliente.salvar();


