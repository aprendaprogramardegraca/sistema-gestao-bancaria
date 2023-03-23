var novaContaPP = new ContaBancaria("Pedro Paulo", 1500);
Console.WriteLine($"Conta {novaContaPP.Numero} foi criada com sucesso para o {novaContaPP.Proprietario} com saldo inicial de: {novaContaPP.Saldo}");
novaContaPP.FazerSaque(800, DateTime.Now, "Pagamento de aluguel");
Console.WriteLine($"Conta {novaContaPP.Numero} foi criada com sucesso para o {novaContaPP.Proprietario} com saldo inicial de: {novaContaPP.Saldo}");

//var novaContaJSC = new ContaBancaria("José da Silva Costa", 458);
//Console.WriteLine($"Conta {novaContaJSC.Numero} foi criada com sucesso para o {novaContaJSC.Proprietario} com saldo inicial de: {novaContaJSC.Saldo}");

//Console.WriteLine($"Saldo da conta é: {novaContaJSC.Saldo}");