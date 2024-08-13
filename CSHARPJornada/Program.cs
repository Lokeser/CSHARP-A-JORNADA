// See https://aka.ms/new-console-template for more information
using CSHARPJornada.utility;
int opcao = 0, num1, num2;
do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1} Somar");
    Console.WriteLine("2} Multiplicar");
    Console.WriteLine("3} Fatorial");
    Console.WriteLine("0} Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            break;
        case 1:
            LerDoisNumerosInteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine($"O Resultado da Soma {num1} com {num2} é {resultado}");
            break;
        case 2:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O Resultado da Multiplicação {num1} com {num2} é {Calculadora.Multiplica(num1, num2)}");
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
} while (opcao != 0);

void LerDoisNumerosInteiros()
{
    Console.WriteLine("Informe o primeiro número: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Segundo número: ");
    num2 = int.Parse(Console.ReadLine());
}