
int opcao = 0;

while (opcao != 5)
{
    Console.Clear();
    Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.WriteLine();

    Console.Write("Digite a opção desejada: ");
    int.TryParse(Console.ReadLine(), out opcao);

    if (opcao >= 1 && opcao <= 4)
    {
        Console.Write("Digite o primeiro número: ");
        double primeiroNumero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double segundoNumero = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = primeiroNumero + segundoNumero;
                Console.WriteLine($"Resultado da Adição: {resultado}");
                break;

            case 2:
                resultado = primeiroNumero - segundoNumero;
                Console.WriteLine($"Resultado da Subtração: {resultado}");
                break;

            case 3:
                resultado = primeiroNumero * segundoNumero;
                Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                break;

            case 4:
                if (segundoNumero == 0)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                }
                else
                {
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine($"Resultado da Divisão: {resultado}");
                }
                break;
        }
    }
    else if (opcao == 5)
    {
        Console.WriteLine("Encerrando a calculadora...");
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }

    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}
   