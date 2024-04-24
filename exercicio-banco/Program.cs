// See https://aka.ms/new-console-template for more information
Conta contaMachiner = new Conta();
contaMachiner.TipoConta = "Poupança";
contaMachiner.NumeroConta = 12345;
contaMachiner.Saldo = 500;
contaMachiner.Trasacao("deposito", 200);

Transacao transacao = new Transacao();
transacao.ExibirDetalhes(contaMachiner);