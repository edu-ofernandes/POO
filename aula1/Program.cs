// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o número do mês: ");
int mes = int.Parse(Console.ReadLine());

switch(mes) {
    case 1:
        Console.WriteLine("O mês escolhido é Janeiro");
        break;
    default:
        Console.WriteLine("Informe um valor entre 1 e 12.");
        break;
}