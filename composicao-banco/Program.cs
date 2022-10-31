using composicao_banco.models;

List<ContaCorrente> contaCorrente = new List<ContaCorrente>();
List<Poupanca> poupanca = new List<Poupanca>();

ContaCorrente conta1 = new ContaCorrente();

Poupanca poupanca1 = new Poupanca();

contaCorrente.Add(conta1);
poupanca.Add(poupanca1);

Banco banco = new Banco(contaCorrente, poupanca);