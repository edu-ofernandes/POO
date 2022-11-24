Gerar o arquivo .ZIP do projeto para enviar nesta tarefa.
Implementar o projeto e seguir as instruções passadas nos slides 20 e 21 do assunto de Interface.

Crie uma interface chamada Itributavel, nela terá o método
double CalculaTributos();
• Este método não recebe nenhum parâmetro e devolve um double
que representa o valor do imposto que deve ser pago
• Crie a classe chamada de ContaCorrente que implemente a interface
Itributavel, que pagará 5% de seu saldo como imposto
• Crie outra classe chamada de SeguroDeVida e faça com que essa
classe implemente a interface Itributavel, o método CalculaTributos
do SeguroDeVida deve devolver um valor constante de 75 reais
• Faça instâncias de cada classe e teste no método main()Continuação do exercício
• Crie outra classe chamada TotalizadorDeTributos , que será responsável por
acumular os impostos das diferentes classes tributáveis, crie uma instância
e teste no método main().

public class TotalizadorDeTributos
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel t)
    {
    this.Total += t.CalculaTributos();
    }
}