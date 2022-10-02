using System;
using EncapsulamentoConta;

Conta contaOrigem = new Conta();
Conta contaDestino = new Conta();

contaOrigem.Titular = "Eduardo Oliveira";
contaOrigem.Saldo = 100;

contaDestino.Titular = "Fulano";
contaDestino.Saldo += 500;

contaDestino.transferirDinheiro(50, contaOrigem);

Console.WriteLine("Conta Origem Saldo: " + contaOrigem.Saldo);
Console.WriteLine("Conta Destion Saldo: " + contaDestino.Saldo);
