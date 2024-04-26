// See https://aka.ms/new-console-template for more information
Conta corrente = new Corrente();
corrente.NumeroConta = 1234;
corrente.Saldo = 1000;
Console.WriteLine(corrente.NumeroConta);
Console.WriteLine(corrente.Saldo);
corrente.Depositar(200);

Console.WriteLine(corrente.Saldo);
corrente.Sacar(300);
Console.WriteLine(corrente.Saldo);

// Transacao transacao = new Transacao(corrente.Depositar().nameof, 200);